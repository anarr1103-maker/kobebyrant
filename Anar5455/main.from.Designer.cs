namespace Anar5455
{
    partial class mainForm
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
            menuStrip1 = new MenuStrip();
            kinoJagsaaltToolStripMenuItem = new ToolStripMenuItem();
            setgegdelToolStripMenuItem = new ToolStripMenuItem();
            yuCymToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { kinoJagsaaltToolStripMenuItem, setgegdelToolStripMenuItem, yuCymToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "mainStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // kinoJagsaaltToolStripMenuItem
            // 
            kinoJagsaaltToolStripMenuItem.Name = "kinoJagsaaltToolStripMenuItem";
            kinoJagsaaltToolStripMenuItem.Size = new Size(87, 20);
            kinoJagsaaltToolStripMenuItem.Text = "Kino Jagsaalt";
            kinoJagsaaltToolStripMenuItem.Click += kinoJagsaaltToolStripMenuItem_Click;
            // 
            // setgegdelToolStripMenuItem
            // 
            setgegdelToolStripMenuItem.Name = "setgegdelToolStripMenuItem";
            setgegdelToolStripMenuItem.Size = new Size(71, 20);
            setgegdelToolStripMenuItem.Text = "Setgegdel";
            // 
            // yuCymToolStripMenuItem
            // 
            yuCymToolStripMenuItem.Name = "yuCymToolStripMenuItem";
            yuCymToolStripMenuItem.Size = new Size(62, 20);
            yuCymToolStripMenuItem.Text = "Yu c ym";
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "mainForm";
            Text = "main";
            Load += mainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem kinoJagsaaltToolStripMenuItem;
        private ToolStripMenuItem setgegdelToolStripMenuItem;
        private ToolStripMenuItem yuCymToolStripMenuItem;
    }
}