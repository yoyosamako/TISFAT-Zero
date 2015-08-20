﻿using Gif.Components;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using TISFAT.Entities;
using TISFAT.Util;

namespace TISFAT
{
	public partial class MainForm : Form
	{
		#region Properties
		public Project ActiveProject;
		private string ProjectFileName;
		private bool ProjectDirty;

		public TimelineForm Form_Timeline;
		public CanvasForm Form_Canvas;
		public ToolboxForm Form_Toolbox;

		public Timeline MainTimeline
		{
			get { return Form_Timeline == null ? null : Form_Timeline.MainTimeline; }
		}

		private static Random Why = new Random();
		#endregion

		public MainForm()
		{
			DoubleBuffered = true;

			InitializeComponent();

			#region General Init
			ProjectNew();
			AddTestLayer();
			#endregion
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			// Create and show forms
			Form_Timeline = new TimelineForm(sc_MainContainer.Panel2);
			Form_Toolbox = new ToolboxForm(sc_MainContainer.Panel2);
			Form_Canvas = new CanvasForm(sc_MainContainer.Panel2);

			Form_Timeline.Show();
			Form_Toolbox.Show();
			Form_Canvas.Show();

			Form_Timeline.Anchor = AnchorStyles.None;
			Form_Toolbox.Anchor = AnchorStyles.None;
			Form_Canvas.Anchor = AnchorStyles.None;

			Form_Timeline.Location = new Point(5, 0);
			Form_Toolbox.Location = new Point(50, Form_Timeline.Location.Y + Form_Timeline.Height + 4);
			Form_Canvas.Location = new Point(Form_Toolbox.Location.X + Form_Toolbox.Width + 20, Form_Timeline.Location.Y + Form_Timeline.Height + 4);
			
			AddTestBitmapLayer();
		}

		private void AddTestLayer()
		{
			StickFigure figure = new StickFigure();

			var hip = new StickFigure.Joint();
			hip.Location = new PointF(200, 200);
			figure.Root = hip;
			var shoulder = StickFigure.Joint.RelativeTo(hip, new PointF(0, -53));
			var lElbow = StickFigure.Joint.RelativeTo(shoulder, new PointF(-21, 22));
			var lHand = StickFigure.Joint.RelativeTo(lElbow, new PointF(-5, 35));
			var rElbow = StickFigure.Joint.RelativeTo(shoulder, new PointF(21, 22));
			var rHand = StickFigure.Joint.RelativeTo(rElbow, new PointF(5, 35));
			var lKnee = StickFigure.Joint.RelativeTo(hip, new PointF(-16, 33));
			var lFoot = StickFigure.Joint.RelativeTo(lKnee, new PointF(-5, 41));
			var rKnee = StickFigure.Joint.RelativeTo(hip, new PointF(16, 33));
			var rFoot = StickFigure.Joint.RelativeTo(rKnee, new PointF(5, 41));
			var head = StickFigure.Joint.RelativeTo(shoulder, new PointF(0, -36));

			shoulder.HandleColor = Color.Yellow;
			hip.HandleColor = Color.Yellow;
			rElbow.HandleColor = Color.Red;
			rHand.HandleColor = Color.Red;
			rKnee.HandleColor = Color.Red;
			rFoot.HandleColor = Color.Red;

			head.HandleColor = Color.Yellow;
			head.IsCircle = true;

			Layer layer = new Layer(figure);
			layer.Framesets.Add(new Frameset());
			layer.Framesets[0].Keyframes.Add(new Keyframe(0, figure.CreateRefState()));
			layer.Framesets[0].Keyframes.Add(new Keyframe(20, figure.CreateRefState()));

			ActiveProject.Layers.Add(layer);

			if (MainTimeline != null)
				MainTimeline.GLContext.Invalidate();
		}

		private void AddTestBitmapLayer()
		{
			BitmapObject figure = new BitmapObject();

			//figure.Texture = Properties.Resources.eye;
			figure.Texture = (Bitmap)Bitmap.FromFile("C:\\Users\\Evar\\Desktop\\boy.png", true);
			figure.TextureID = Drawing.GenerateTexID(figure.Texture);

			Layer layer = new Layer(figure);
			layer.Framesets.Add(new Frameset());
			layer.Framesets[0].Keyframes.Add(new Keyframe(0, figure.CreateRefState()));
			layer.Framesets[0].Keyframes.Add(new Keyframe(20, figure.CreateRefState()));

			ActiveProject.Layers.Add(layer);

			if (MainTimeline != null)
				MainTimeline.GLContext.Invalidate();
		}

		public void SetDirty(bool dirty)
		{
			ProjectDirty = dirty;
			Text = "TISFAT Zero - " + (Path.GetFileNameWithoutExtension(ProjectFileName) ?? "Untitled") + (dirty ? " *" : "");
		}

		private void SetFileName(string filename)
		{
			ProjectFileName = filename;
			SetDirty(filename == null);
		}

		#region File Saving / Loading
		public void ProjectNew()
		{
			ActiveProject = new Project();
			SetFileName(null);

			if(MainTimeline != null)
				MainTimeline.GLContext.Invalidate();
		}

		public void ProjectOpen(string filename)
		{
			if (MainTimeline == null)
				return;

			ActiveProject = new Project();

			using (var reader = new BinaryReader(new FileStream(filename, FileMode.Open)))
			{
				UInt16 version = reader.ReadUInt16();
				ActiveProject.Read(reader, version);
			}

			SetFileName(filename);

			if (MainTimeline != null)
				MainTimeline.GLContext.Invalidate();
		}

		public void ProjectSave(string filename)
		{
			if (MainTimeline == null)
				return;

			using (var writer = new BinaryWriter(new FileStream(filename, FileMode.Create)))
			{
				writer.Write(FileFormat.Version);
				ActiveProject.Write(writer);
			}

			SetFileName(filename);
			ProjectFileName = filename;
		}

		private void newToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ProjectNew();
		}

		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.AddExtension = true;
			dialog.Filter = "TISFAT Zero Project|*.tzp";

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				ProjectOpen(dialog.FileName);
			}
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (ProjectFileName != null)
				ProjectSave(ProjectFileName);
			else
				saveAsToolStripMenuItem_Click(sender, e);
		}

		private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog dialog = new SaveFileDialog();
			dialog.AddExtension = true;
			dialog.Filter = "TISFAT Zero Project|*.tzp";

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				ProjectSave(dialog.FileName);
			}
		}
		#endregion

		private void animatedGifgifToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog dlg = new SaveFileDialog();
			dlg.Filter = "Animated Gif|*.gif";

			if (dlg.ShowDialog() != DialogResult.OK)
				return;
			FileStream fs = new FileStream(dlg.FileName, FileMode.Create);
			AnimatedGifEncoder g = new AnimatedGifEncoder();

			float fps = 10.0f;
			float delta = 1.0f / fps;

			float endTime = 0.0f;

			foreach (Layer layer in ActiveProject.Layers)
			{
				endTime = Math.Max(endTime, layer.Framesets[layer.Framesets.Count - 1].EndTime);
			}

			g.Start(fs);

			g.SetDelay((int)Math.Round(delta * 1000.0f));
			g.SetQuality(2);
			g.SetRepeat(0);
			
			for (float time = 0; time <= endTime / ActiveProject.FPS; time += delta)
			{
				Form_Canvas.DrawFrame(time * ActiveProject.FPS, true);
				g.AddFrame(Image.FromHbitmap(Form_Canvas.TakeScreenshot()));
			}

			g.Finish();
		}
	}
}
