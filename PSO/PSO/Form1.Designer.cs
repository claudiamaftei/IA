namespace PSO
{
    partial class Particle_Swarm_Optimization
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
            this.generate_input = new System.Windows.Forms.Button();
            this.find_the_path = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.diagramView1 = new MindFusion.Diagramming.WinForms.DiagramView();
            this.diagram1 = new MindFusion.Diagramming.Diagram();
            this.reset_graph = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // generate_input
            // 
            this.generate_input.BackColor = System.Drawing.Color.PaleTurquoise;
            this.generate_input.Cursor = System.Windows.Forms.Cursors.Hand;
            this.generate_input.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.generate_input.FlatAppearance.BorderSize = 2;
            this.generate_input.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen;
            this.generate_input.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generate_input.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.generate_input.Location = new System.Drawing.Point(185, 293);
            this.generate_input.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.generate_input.Name = "generate_input";
            this.generate_input.Size = new System.Drawing.Size(147, 50);
            this.generate_input.TabIndex = 5;
            this.generate_input.Text = "Generate input";
            this.generate_input.UseMnemonic = false;
            this.generate_input.UseVisualStyleBackColor = false;
            this.generate_input.Click += new System.EventHandler(this.generate_input_Click);
            // 
            // find_the_path
            // 
            this.find_the_path.BackColor = System.Drawing.Color.PaleTurquoise;
            this.find_the_path.Cursor = System.Windows.Forms.Cursors.Hand;
            this.find_the_path.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.find_the_path.FlatAppearance.BorderSize = 2;
            this.find_the_path.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen;
            this.find_the_path.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.find_the_path.Location = new System.Drawing.Point(397, 293);
            this.find_the_path.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.find_the_path.Name = "find_the_path";
            this.find_the_path.Size = new System.Drawing.Size(148, 50);
            this.find_the_path.TabIndex = 6;
            this.find_the_path.Text = "Find the path";
            this.find_the_path.UseVisualStyleBackColor = false;
            this.find_the_path.Click += new System.EventHandler(this.find_the_path_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightCyan;
            this.textBox1.Location = new System.Drawing.Point(185, 371);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(569, 70);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // diagramView1
            // 
            this.diagramView1.BackColor = System.Drawing.Color.LightCyan;
            this.diagramView1.Diagram = this.diagram1;
            this.diagramView1.LicenseKey = null;
            this.diagramView1.Location = new System.Drawing.Point(185, 54);
            this.diagramView1.Name = "diagramView1";
            this.diagramView1.Size = new System.Drawing.Size(569, 204);
            this.diagramView1.TabIndex = 8;
            this.diagramView1.Text = "diagramView1";
            this.diagramView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.diagramView1_MouseDown);
            this.diagramView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.diagramView1_MouseUp);
            // 
            // diagram1
            // 
            this.diagram1.TouchThreshold = 0F;
            // 
            // reset_graph
            // 
            this.reset_graph.BackColor = System.Drawing.Color.PaleTurquoise;
            this.reset_graph.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reset_graph.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.reset_graph.FlatAppearance.BorderSize = 2;
            this.reset_graph.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen;
            this.reset_graph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reset_graph.Location = new System.Drawing.Point(606, 293);
            this.reset_graph.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.reset_graph.Name = "reset_graph";
            this.reset_graph.Size = new System.Drawing.Size(148, 50);
            this.reset_graph.TabIndex = 9;
            this.reset_graph.Text = "Reset Graph";
            this.reset_graph.UseVisualStyleBackColor = false;
            this.reset_graph.Click += new System.EventHandler(this.reset_graph_Click);
            // 
            // Particle_Swarm_Optimization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PSO.Properties.Resources.unnamed;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(939, 490);
            this.Controls.Add(this.reset_graph);
            this.Controls.Add(this.diagramView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.find_the_path);
            this.Controls.Add(this.generate_input);
            this.Font = new System.Drawing.Font("Showcard Gothic", 8.25F);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "Particle_Swarm_Optimization";
            this.Text = "ParticleSwarmOptimization";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button generate_input;
        private System.Windows.Forms.Button find_the_path;
        private System.Windows.Forms.TextBox textBox1;
        private MindFusion.Diagramming.WinForms.DiagramView diagramView1;
        private MindFusion.Diagramming.Diagram diagram1;
        private System.Windows.Forms.Button reset_graph;
    }
}

