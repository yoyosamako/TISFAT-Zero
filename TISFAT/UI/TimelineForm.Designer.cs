﻿namespace TISFAT
{
    partial class TimelineForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.pnl_ScrollSquare = new System.Windows.Forms.Panel();
			this.scrl_VTimeline = new System.Windows.Forms.VScrollBar();
			this.scrl_HTimeline = new System.Windows.Forms.HScrollBar();
			this.GLContext = new OpenTK.GLControl();
			this.pnl_ToolboxPanel = new System.Windows.Forms.Panel();
			this.btn_SeekStart = new TISFAT.Controls.BitmapButtonControl();
			this.btn_Rewind = new TISFAT.Controls.BitmapButtonControl();
			this.btn_SeekEnd = new TISFAT.Controls.BitmapButtonControl();
			this.btn_FastForward = new TISFAT.Controls.BitmapButtonControl();
			this.btn_PlayPause = new TISFAT.Controls.BitmapButtonControl();
			this.cxtm_Timeline = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.insertKeyframeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.removeKeyframeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.insertFramesetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.removeFramesetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
			this.moveLayerUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.moveLayerDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.removeLayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.gotoFrameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.setPoseToPreviousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.setPoseToNextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pnl_ToolboxPanel.SuspendLayout();
			this.cxtm_Timeline.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnl_ScrollSquare
			// 
			this.pnl_ScrollSquare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_ScrollSquare.BackColor = System.Drawing.SystemColors.Control;
			this.pnl_ScrollSquare.Location = new System.Drawing.Point(735, 132);
			this.pnl_ScrollSquare.Margin = new System.Windows.Forms.Padding(0);
			this.pnl_ScrollSquare.Name = "pnl_ScrollSquare";
			this.pnl_ScrollSquare.Size = new System.Drawing.Size(17, 17);
			this.pnl_ScrollSquare.TabIndex = 9;
			// 
			// scrl_VTimeline
			// 
			this.scrl_VTimeline.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.scrl_VTimeline.LargeChange = 1;
			this.scrl_VTimeline.Location = new System.Drawing.Point(735, 1);
			this.scrl_VTimeline.Maximum = 0;
			this.scrl_VTimeline.Name = "scrl_VTimeline";
			this.scrl_VTimeline.Size = new System.Drawing.Size(17, 131);
			this.scrl_VTimeline.TabIndex = 8;
			this.scrl_VTimeline.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrl_Timeline_Scroll);
			// 
			// scrl_HTimeline
			// 
			this.scrl_HTimeline.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.scrl_HTimeline.LargeChange = 1;
			this.scrl_HTimeline.Location = new System.Drawing.Point(0, 132);
			this.scrl_HTimeline.Maximum = 0;
			this.scrl_HTimeline.Name = "scrl_HTimeline";
			this.scrl_HTimeline.Size = new System.Drawing.Size(735, 17);
			this.scrl_HTimeline.TabIndex = 7;
			this.scrl_HTimeline.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrl_Timeline_Scroll);
			// 
			// GLContext
			// 
			this.GLContext.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.GLContext.BackColor = System.Drawing.Color.Black;
			this.GLContext.Location = new System.Drawing.Point(1, 1);
			this.GLContext.Margin = new System.Windows.Forms.Padding(0);
			this.GLContext.Name = "GLContext";
			this.GLContext.Size = new System.Drawing.Size(751, 148);
			this.GLContext.TabIndex = 5;
			this.GLContext.VSync = false;
			this.GLContext.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GLContext_MouseDown);
			this.GLContext.MouseLeave += new System.EventHandler(this.GLContext_MouseLeave);
			this.GLContext.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GLContext_MouseMove);
			this.GLContext.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GLContext_MouseUp);
			// 
			// pnl_ToolboxPanel
			// 
			this.pnl_ToolboxPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_ToolboxPanel.BackColor = System.Drawing.SystemColors.Control;
			this.pnl_ToolboxPanel.Controls.Add(this.btn_SeekStart);
			this.pnl_ToolboxPanel.Controls.Add(this.btn_Rewind);
			this.pnl_ToolboxPanel.Controls.Add(this.btn_SeekEnd);
			this.pnl_ToolboxPanel.Controls.Add(this.btn_FastForward);
			this.pnl_ToolboxPanel.Controls.Add(this.btn_PlayPause);
			this.pnl_ToolboxPanel.Location = new System.Drawing.Point(1, 149);
			this.pnl_ToolboxPanel.Margin = new System.Windows.Forms.Padding(0);
			this.pnl_ToolboxPanel.Name = "pnl_ToolboxPanel";
			this.pnl_ToolboxPanel.Size = new System.Drawing.Size(751, 30);
			this.pnl_ToolboxPanel.TabIndex = 6;
			// 
			// btn_SeekStart
			// 
			this.btn_SeekStart.Checked = false;
			this.btn_SeekStart.ImageDefault = global::TISFAT.Properties.Resources.control_start;
			this.btn_SeekStart.ImageDown = global::TISFAT.Properties.Resources.control_start;
			this.btn_SeekStart.ImageHover = global::TISFAT.Properties.Resources.control_start_blue;
			this.btn_SeekStart.ImageOn = null;
			this.btn_SeekStart.ImageOnDown = null;
			this.btn_SeekStart.ImageOnHover = null;
			this.btn_SeekStart.Location = new System.Drawing.Point(303, 3);
			this.btn_SeekStart.Name = "btn_SeekStart";
			this.btn_SeekStart.Size = new System.Drawing.Size(24, 24);
			this.btn_SeekStart.TabIndex = 14;
			this.btn_SeekStart.ToggleButton = false;
			this.btn_SeekStart.Click += new System.EventHandler(this.btn_SeekStart_Click);
			// 
			// btn_Rewind
			// 
			this.btn_Rewind.Checked = false;
			this.btn_Rewind.ImageDefault = global::TISFAT.Properties.Resources.control_rewind;
			this.btn_Rewind.ImageDown = global::TISFAT.Properties.Resources.control_rewind;
			this.btn_Rewind.ImageHover = global::TISFAT.Properties.Resources.control_rewind_blue;
			this.btn_Rewind.ImageOn = null;
			this.btn_Rewind.ImageOnDown = null;
			this.btn_Rewind.ImageOnHover = null;
			this.btn_Rewind.Location = new System.Drawing.Point(333, 3);
			this.btn_Rewind.Name = "btn_Rewind";
			this.btn_Rewind.Size = new System.Drawing.Size(24, 24);
			this.btn_Rewind.TabIndex = 13;
			this.btn_Rewind.ToggleButton = false;
			// 
			// btn_SeekEnd
			// 
			this.btn_SeekEnd.Checked = false;
			this.btn_SeekEnd.ImageDefault = global::TISFAT.Properties.Resources.control_end;
			this.btn_SeekEnd.ImageDown = global::TISFAT.Properties.Resources.control_end;
			this.btn_SeekEnd.ImageHover = global::TISFAT.Properties.Resources.control_end_blue;
			this.btn_SeekEnd.ImageOn = null;
			this.btn_SeekEnd.ImageOnDown = null;
			this.btn_SeekEnd.ImageOnHover = null;
			this.btn_SeekEnd.Location = new System.Drawing.Point(423, 3);
			this.btn_SeekEnd.Name = "btn_SeekEnd";
			this.btn_SeekEnd.Size = new System.Drawing.Size(24, 24);
			this.btn_SeekEnd.TabIndex = 12;
			this.btn_SeekEnd.ToggleButton = false;
			this.btn_SeekEnd.Click += new System.EventHandler(this.btn_SeekEnd_Click);
			// 
			// btn_FastForward
			// 
			this.btn_FastForward.Checked = false;
			this.btn_FastForward.ImageDefault = global::TISFAT.Properties.Resources.control_fastforward;
			this.btn_FastForward.ImageDown = global::TISFAT.Properties.Resources.control_fastforward;
			this.btn_FastForward.ImageHover = global::TISFAT.Properties.Resources.control_fastforward_blue;
			this.btn_FastForward.ImageOn = null;
			this.btn_FastForward.ImageOnDown = null;
			this.btn_FastForward.ImageOnHover = null;
			this.btn_FastForward.Location = new System.Drawing.Point(393, 3);
			this.btn_FastForward.Name = "btn_FastForward";
			this.btn_FastForward.Size = new System.Drawing.Size(24, 24);
			this.btn_FastForward.TabIndex = 11;
			this.btn_FastForward.ToggleButton = false;
			// 
			// btn_PlayPause
			// 
			this.btn_PlayPause.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btn_PlayPause.Checked = false;
			this.btn_PlayPause.ImageDefault = global::TISFAT.Properties.Resources.control_play;
			this.btn_PlayPause.ImageDown = global::TISFAT.Properties.Resources.control_play;
			this.btn_PlayPause.ImageHover = global::TISFAT.Properties.Resources.control_play_blue;
			this.btn_PlayPause.ImageOn = global::TISFAT.Properties.Resources.control_pause;
			this.btn_PlayPause.ImageOnDown = global::TISFAT.Properties.Resources.control_pause;
			this.btn_PlayPause.ImageOnHover = global::TISFAT.Properties.Resources.control_pause_blue;
			this.btn_PlayPause.Location = new System.Drawing.Point(363, 3);
			this.btn_PlayPause.Name = "btn_PlayPause";
			this.btn_PlayPause.Size = new System.Drawing.Size(24, 24);
			this.btn_PlayPause.TabIndex = 10;
			this.btn_PlayPause.ToggleButton = true;
			this.btn_PlayPause.Click += new System.EventHandler(this.btn_PlayPause_Click);
			// 
			// cxtm_Timeline
			// 
			this.cxtm_Timeline.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertKeyframeToolStripMenuItem,
            this.removeKeyframeToolStripMenuItem,
            this.setPoseToPreviousToolStripMenuItem,
            this.setPoseToNextToolStripMenuItem,
            this.toolStripSeparator4,
            this.insertFramesetToolStripMenuItem,
            this.removeFramesetToolStripMenuItem,
            this.toolStripSeparator6,
            this.moveLayerUpToolStripMenuItem,
            this.moveLayerDownToolStripMenuItem,
            this.removeLayerToolStripMenuItem,
            this.toolStripSeparator5,
            this.gotoFrameToolStripMenuItem});
			this.cxtm_Timeline.Name = "cxtm_Timeline";
			this.cxtm_Timeline.Size = new System.Drawing.Size(234, 264);
			// 
			// insertKeyframeToolStripMenuItem
			// 
			this.insertKeyframeToolStripMenuItem.Name = "insertKeyframeToolStripMenuItem";
			this.insertKeyframeToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
			this.insertKeyframeToolStripMenuItem.Text = "Insert Keyframe";
			this.insertKeyframeToolStripMenuItem.Click += new System.EventHandler(this.insertKeyframeToolStripMenuItem_Click);
			// 
			// removeKeyframeToolStripMenuItem
			// 
			this.removeKeyframeToolStripMenuItem.Name = "removeKeyframeToolStripMenuItem";
			this.removeKeyframeToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
			this.removeKeyframeToolStripMenuItem.Text = "Remove Keyframe";
			this.removeKeyframeToolStripMenuItem.Click += new System.EventHandler(this.removeKeyframeToolStripMenuItem_Click);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(230, 6);
			// 
			// insertFramesetToolStripMenuItem
			// 
			this.insertFramesetToolStripMenuItem.Name = "insertFramesetToolStripMenuItem";
			this.insertFramesetToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
			this.insertFramesetToolStripMenuItem.Text = "Insert Frameset";
			this.insertFramesetToolStripMenuItem.Click += new System.EventHandler(this.insertFramesetToolStripMenuItem_Click);
			// 
			// removeFramesetToolStripMenuItem
			// 
			this.removeFramesetToolStripMenuItem.Name = "removeFramesetToolStripMenuItem";
			this.removeFramesetToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
			this.removeFramesetToolStripMenuItem.Text = "Remove Frameset";
			this.removeFramesetToolStripMenuItem.Click += new System.EventHandler(this.removeFramesetToolStripMenuItem_Click);
			// 
			// toolStripSeparator6
			// 
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			this.toolStripSeparator6.Size = new System.Drawing.Size(230, 6);
			// 
			// moveLayerUpToolStripMenuItem
			// 
			this.moveLayerUpToolStripMenuItem.Name = "moveLayerUpToolStripMenuItem";
			this.moveLayerUpToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
			this.moveLayerUpToolStripMenuItem.Text = "Move Layer Up";
			this.moveLayerUpToolStripMenuItem.Click += new System.EventHandler(this.moveLayerUpToolStripMenuItem_Click);
			// 
			// moveLayerDownToolStripMenuItem
			// 
			this.moveLayerDownToolStripMenuItem.Name = "moveLayerDownToolStripMenuItem";
			this.moveLayerDownToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
			this.moveLayerDownToolStripMenuItem.Text = "Move Layer Down";
			this.moveLayerDownToolStripMenuItem.Click += new System.EventHandler(this.moveLayerDownToolStripMenuItem_Click);
			// 
			// removeLayerToolStripMenuItem
			// 
			this.removeLayerToolStripMenuItem.Name = "removeLayerToolStripMenuItem";
			this.removeLayerToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
			this.removeLayerToolStripMenuItem.Text = "Remove Layer";
			this.removeLayerToolStripMenuItem.Click += new System.EventHandler(this.removeLayerToolStripMenuItem_Click);
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(230, 6);
			// 
			// gotoFrameToolStripMenuItem
			// 
			this.gotoFrameToolStripMenuItem.Enabled = false;
			this.gotoFrameToolStripMenuItem.Name = "gotoFrameToolStripMenuItem";
			this.gotoFrameToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
			this.gotoFrameToolStripMenuItem.Text = "Goto Frame";
			// 
			// setPoseToPreviousToolStripMenuItem
			// 
			this.setPoseToPreviousToolStripMenuItem.Name = "setPoseToPreviousToolStripMenuItem";
			this.setPoseToPreviousToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
			this.setPoseToPreviousToolStripMenuItem.Text = "Set Pose to Previous Keyframe";
			this.setPoseToPreviousToolStripMenuItem.Click += new System.EventHandler(this.setPoseToPreviousToolStripMenuItem_Click);
			// 
			// setPoseToNextToolStripMenuItem
			// 
			this.setPoseToNextToolStripMenuItem.Name = "setPoseToNextToolStripMenuItem";
			this.setPoseToNextToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
			this.setPoseToNextToolStripMenuItem.Text = "Set Pose to Next Keyframe";
			this.setPoseToNextToolStripMenuItem.Click += new System.EventHandler(this.setPoseToNextToolStripMenuItem_Click);
			// 
			// TimelineForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(752, 179);
			this.ControlBox = false;
			this.Controls.Add(this.pnl_ScrollSquare);
			this.Controls.Add(this.scrl_VTimeline);
			this.Controls.Add(this.scrl_HTimeline);
			this.Controls.Add(this.GLContext);
			this.Controls.Add(this.pnl_ToolboxPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.MinimumSize = new System.Drawing.Size(768, 136);
			this.Name = "TimelineForm";
			this.Text = "Timeline";
			this.Load += new System.EventHandler(this.TimelineForm_Load);
			this.Enter += new System.EventHandler(this.TimelineForm_Enter);
			this.Resize += new System.EventHandler(this.TimelineForm_Resize);
			this.pnl_ToolboxPanel.ResumeLayout(false);
			this.cxtm_Timeline.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_ScrollSquare;
        private System.Windows.Forms.VScrollBar scrl_VTimeline;
        private System.Windows.Forms.HScrollBar scrl_HTimeline;
        private OpenTK.GLControl GLContext;
        private System.Windows.Forms.Panel pnl_ToolboxPanel;
        private System.Windows.Forms.ContextMenuStrip cxtm_Timeline;
        private System.Windows.Forms.ToolStripMenuItem insertKeyframeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeKeyframeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem insertFramesetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeFramesetToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem moveLayerUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveLayerDownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeLayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem gotoFrameToolStripMenuItem;
        private Controls.BitmapButtonControl btn_PlayPause;
		private Controls.BitmapButtonControl btn_SeekStart;
		private Controls.BitmapButtonControl btn_Rewind;
		private Controls.BitmapButtonControl btn_SeekEnd;
		private Controls.BitmapButtonControl btn_FastForward;
		private System.Windows.Forms.ToolStripMenuItem setPoseToPreviousToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem setPoseToNextToolStripMenuItem;
	}
}