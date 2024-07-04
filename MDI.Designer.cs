namespace TrabajoFinal
{
    partial class MDI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nuevoRegistroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarRegistroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarRegistroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serializacionEnXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.javaScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serializacionEnJSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.javaScriptToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoRegistroToolStripMenuItem,
            this.modificarRegistroToolStripMenuItem,
            this.eliminarRegistroToolStripMenuItem,
            this.exportacionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nuevoRegistroToolStripMenuItem
            // 
            this.nuevoRegistroToolStripMenuItem.Name = "nuevoRegistroToolStripMenuItem";
            this.nuevoRegistroToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.nuevoRegistroToolStripMenuItem.Text = "Nuevo Registro";
            this.nuevoRegistroToolStripMenuItem.Click += new System.EventHandler(this.nuevoRegistroToolStripMenuItem_Click);
            // 
            // modificarRegistroToolStripMenuItem
            // 
            this.modificarRegistroToolStripMenuItem.Name = "modificarRegistroToolStripMenuItem";
            this.modificarRegistroToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.modificarRegistroToolStripMenuItem.Text = "Modificar Registro";
            // 
            // eliminarRegistroToolStripMenuItem
            // 
            this.eliminarRegistroToolStripMenuItem.Name = "eliminarRegistroToolStripMenuItem";
            this.eliminarRegistroToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.eliminarRegistroToolStripMenuItem.Text = "Eliminar Registro";
            // 
            // exportacionesToolStripMenuItem
            // 
            this.exportacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializacionEnXMLToolStripMenuItem,
            this.serializacionEnJSONToolStripMenuItem});
            this.exportacionesToolStripMenuItem.Name = "exportacionesToolStripMenuItem";
            this.exportacionesToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.exportacionesToolStripMenuItem.Text = "Exportaciones";
            // 
            // serializacionEnXMLToolStripMenuItem
            // 
            this.serializacionEnXMLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cToolStripMenuItem,
            this.cToolStripMenuItem1,
            this.javaScriptToolStripMenuItem});
            this.serializacionEnXMLToolStripMenuItem.Name = "serializacionEnXMLToolStripMenuItem";
            this.serializacionEnXMLToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.serializacionEnXMLToolStripMenuItem.Text = "Serializacion en XML";
            // 
            // cToolStripMenuItem
            // 
            this.cToolStripMenuItem.Name = "cToolStripMenuItem";
            this.cToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cToolStripMenuItem.Text = "C#";
            this.cToolStripMenuItem.Click += new System.EventHandler(this.cToolStripMenuItem_Click);
            // 
            // cToolStripMenuItem1
            // 
            this.cToolStripMenuItem1.Name = "cToolStripMenuItem1";
            this.cToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.cToolStripMenuItem1.Text = "C++";
            this.cToolStripMenuItem1.Click += new System.EventHandler(this.cToolStripMenuItem1_Click);
            // 
            // javaScriptToolStripMenuItem
            // 
            this.javaScriptToolStripMenuItem.Name = "javaScriptToolStripMenuItem";
            this.javaScriptToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.javaScriptToolStripMenuItem.Text = "JavaScript";
            this.javaScriptToolStripMenuItem.Click += new System.EventHandler(this.javaScriptToolStripMenuItem_Click);
            // 
            // serializacionEnJSONToolStripMenuItem
            // 
            this.serializacionEnJSONToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cToolStripMenuItem2,
            this.cToolStripMenuItem3,
            this.javaScriptToolStripMenuItem1});
            this.serializacionEnJSONToolStripMenuItem.Name = "serializacionEnJSONToolStripMenuItem";
            this.serializacionEnJSONToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.serializacionEnJSONToolStripMenuItem.Text = "Serializacion en JSON";
            // 
            // cToolStripMenuItem2
            // 
            this.cToolStripMenuItem2.Name = "cToolStripMenuItem2";
            this.cToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.cToolStripMenuItem2.Text = "C#";
            this.cToolStripMenuItem2.Click += new System.EventHandler(this.cToolStripMenuItem2_Click);
            // 
            // cToolStripMenuItem3
            // 
            this.cToolStripMenuItem3.Name = "cToolStripMenuItem3";
            this.cToolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.cToolStripMenuItem3.Text = "C++";
            this.cToolStripMenuItem3.Click += new System.EventHandler(this.cToolStripMenuItem3_Click);
            // 
            // javaScriptToolStripMenuItem1
            // 
            this.javaScriptToolStripMenuItem1.Name = "javaScriptToolStripMenuItem1";
            this.javaScriptToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.javaScriptToolStripMenuItem1.Text = "JavaScript";
            this.javaScriptToolStripMenuItem1.Click += new System.EventHandler(this.javaScriptToolStripMenuItem1_Click);
            // 
            // MDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MDI";
            this.Text = "Inicio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MDI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nuevoRegistroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarRegistroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarRegistroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serializacionEnXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem javaScriptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serializacionEnJSONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem javaScriptToolStripMenuItem1;
    }
}