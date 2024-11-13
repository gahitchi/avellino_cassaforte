namespace cassaforte
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
            TBcodiceUtente = new TextBox();
            labelCodiceUtente = new Label();
            labelCodiceAccesso = new Label();
            TBcodiceAccesso = new TextBox();
            SuspendLayout();
            // 
            // TBcodiceUtente
            // 
            TBcodiceUtente.Location = new Point(21, 39);
            TBcodiceUtente.Name = "TBcodiceUtente";
            TBcodiceUtente.Size = new Size(129, 23);
            TBcodiceUtente.TabIndex = 0;
            TBcodiceUtente.TextChanged += TBcodiceUtente_TextChanged;
            // 
            // labelCodiceUtente
            // 
            labelCodiceUtente.AutoSize = true;
            labelCodiceUtente.Location = new Point(21, 21);
            labelCodiceUtente.Name = "labelCodiceUtente";
            labelCodiceUtente.Size = new Size(129, 15);
            labelCodiceUtente.TabIndex = 1;
            labelCodiceUtente.Text = "inserire il codice utente";
            // 
            // labelCodiceAccesso
            // 
            labelCodiceAccesso.AutoSize = true;
            labelCodiceAccesso.Location = new Point(365, 21);
            labelCodiceAccesso.Name = "labelCodiceAccesso";
            labelCodiceAccesso.Size = new Size(140, 15);
            labelCodiceAccesso.TabIndex = 2;
            labelCodiceAccesso.Text = "inserire codice di accesso";
            // 
            // TBcodiceAccesso
            // 
            TBcodiceAccesso.Location = new Point(365, 39);
            TBcodiceAccesso.Name = "TBcodiceAccesso";
            TBcodiceAccesso.Size = new Size(140, 23);
            TBcodiceAccesso.TabIndex = 3;
            TBcodiceAccesso.TextChanged += TBcodiceAccesso_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TBcodiceAccesso);
            Controls.Add(labelCodiceAccesso);
            Controls.Add(labelCodiceUtente);
            Controls.Add(TBcodiceUtente);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Shown += TBcodiceAccesso_TextChanged;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TBcodiceUtente;
        private Label labelCodiceUtente;
        private Label labelCodiceAccesso;
        private TextBox TBcodiceAccesso;
    }
}
