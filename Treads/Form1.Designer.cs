namespace Treads
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pcb_color = new PictureBox();
            btn_Iniciar = new Button();
            ((System.ComponentModel.ISupportInitialize)pcb_color).BeginInit();
            SuspendLayout();
            // 
            // pcb_color
            // 
            pcb_color.Location = new Point(32, 28);
            pcb_color.Name = "pcb_color";
            pcb_color.Size = new Size(400, 312);
            pcb_color.TabIndex = 0;
            pcb_color.TabStop = false;
            // 
            // btn_Iniciar
            // 
            btn_Iniciar.Location = new Point(175, 365);
            btn_Iniciar.Name = "btn_Iniciar";
            btn_Iniciar.Size = new Size(112, 34);
            btn_Iniciar.TabIndex = 1;
            btn_Iniciar.Text = "Iniciar";
            btn_Iniciar.UseVisualStyleBackColor = true;
            btn_Iniciar.Click += btn_Iniciar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 450);
            Controls.Add(btn_Iniciar);
            Controls.Add(pcb_color);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pcb_color).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pcb_color;
        private Button btn_Iniciar;
    }
}
