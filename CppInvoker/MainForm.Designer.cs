namespace CppInvoker
{

    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.ContainerPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.LeftColumn = new System.Windows.Forms.FlowLayoutPanel();
            this.lblFirstNumber = new System.Windows.Forms.Label();
            this.numFirst = new System.Windows.Forms.NumericUpDown();
            this.lblSecondNumber = new System.Windows.Forms.Label();
            this.numSecond = new System.Windows.Forms.NumericUpDown();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblCalculatedResult = new System.Windows.Forms.Label();
            this.RightColumn = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnDiff = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.errValidator = new System.Windows.Forms.ErrorProvider(this.components);
            this.ContainerPanel.SuspendLayout();
            this.LeftColumn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFirst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSecond)).BeginInit();
            this.RightColumn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errValidator)).BeginInit();
            this.SuspendLayout();
            // 
            // ContainerPanel
            // 
            this.ContainerPanel.Controls.Add(this.LeftColumn);
            this.ContainerPanel.Controls.Add(this.RightColumn);
            this.ContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContainerPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ContainerPanel.Location = new System.Drawing.Point(0, 0);
            this.ContainerPanel.Name = "ContainerPanel";
            this.ContainerPanel.Size = new System.Drawing.Size(293, 223);
            this.ContainerPanel.TabIndex = 0;
            // 
            // LeftColumn
            // 
            this.LeftColumn.Controls.Add(this.lblFirstNumber);
            this.LeftColumn.Controls.Add(this.numFirst);
            this.LeftColumn.Controls.Add(this.lblSecondNumber);
            this.LeftColumn.Controls.Add(this.numSecond);
            this.LeftColumn.Controls.Add(this.lblResult);
            this.LeftColumn.Controls.Add(this.lblCalculatedResult);
            this.LeftColumn.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.LeftColumn.Location = new System.Drawing.Point(3, 3);
            this.LeftColumn.Name = "LeftColumn";
            this.LeftColumn.Size = new System.Drawing.Size(141, 220);
            this.LeftColumn.TabIndex = 5;
            // 
            // lblFirstNumber
            // 
            this.lblFirstNumber.AutoSize = true;
            this.lblFirstNumber.Location = new System.Drawing.Point(3, 0);
            this.lblFirstNumber.Name = "lblFirstNumber";
            this.lblFirstNumber.Size = new System.Drawing.Size(91, 19);
            this.lblFirstNumber.TabIndex = 0;
            this.lblFirstNumber.Text = "First number";
            // 
            // numFirst
            // 
            this.numFirst.Location = new System.Drawing.Point(3, 22);
            this.numFirst.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numFirst.Name = "numFirst";
            this.numFirst.Size = new System.Drawing.Size(120, 27);
            this.numFirst.TabIndex = 2;
            // 
            // lblSecondNumber
            // 
            this.lblSecondNumber.AutoSize = true;
            this.lblSecondNumber.Location = new System.Drawing.Point(3, 52);
            this.lblSecondNumber.Name = "lblSecondNumber";
            this.lblSecondNumber.Size = new System.Drawing.Size(109, 19);
            this.lblSecondNumber.TabIndex = 1;
            this.lblSecondNumber.Text = "Second number";
            // 
            // numSecond
            // 
            this.numSecond.Location = new System.Drawing.Point(3, 74);
            this.numSecond.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numSecond.Name = "numSecond";
            this.numSecond.Size = new System.Drawing.Size(120, 27);
            this.numSecond.TabIndex = 3;
            this.numSecond.ValueChanged += new System.EventHandler(this.NumSecond_ValueChanged);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(3, 104);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(50, 19);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "Result";
            // 
            // lblCalculatedResult
            // 
            this.lblCalculatedResult.AutoSize = true;
            this.lblCalculatedResult.Location = new System.Drawing.Point(3, 123);
            this.lblCalculatedResult.Name = "lblCalculatedResult";
            this.lblCalculatedResult.Size = new System.Drawing.Size(0, 19);
            this.lblCalculatedResult.TabIndex = 5;
            // 
            // RightColumn
            // 
            this.RightColumn.Controls.Add(this.btnSum);
            this.RightColumn.Controls.Add(this.btnDiff);
            this.RightColumn.Controls.Add(this.btnMult);
            this.RightColumn.Controls.Add(this.btnDiv);
            this.RightColumn.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.RightColumn.Location = new System.Drawing.Point(150, 3);
            this.RightColumn.Name = "RightColumn";
            this.RightColumn.Size = new System.Drawing.Size(143, 220);
            this.RightColumn.TabIndex = 6;
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(3, 3);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(140, 38);
            this.btnSum.TabIndex = 0;
            this.btnSum.Text = "Sum";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.BtnSum_Click);
            // 
            // btnDiff
            // 
            this.btnDiff.Location = new System.Drawing.Point(3, 47);
            this.btnDiff.Name = "btnDiff";
            this.btnDiff.Size = new System.Drawing.Size(140, 38);
            this.btnDiff.TabIndex = 1;
            this.btnDiff.Text = "Diff";
            this.btnDiff.UseVisualStyleBackColor = true;
            this.btnDiff.Click += new System.EventHandler(this.BtnDiff_Click);
            // 
            // btnMult
            // 
            this.btnMult.Location = new System.Drawing.Point(3, 91);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(140, 38);
            this.btnMult.TabIndex = 2;
            this.btnMult.Text = "Mult";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.BtnMult_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(3, 135);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(140, 38);
            this.btnDiv.TabIndex = 3;
            this.btnDiv.Text = "Div";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.BtnDiv_Click);
            // 
            // errValidator
            // 
            this.errValidator.ContainerControl = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 223);
            this.Controls.Add(this.ContainerPanel);
            this.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ContainerPanel.ResumeLayout(false);
            this.LeftColumn.ResumeLayout(false);
            this.LeftColumn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFirst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSecond)).EndInit();
            this.RightColumn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errValidator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel ContainerPanel;
        private System.Windows.Forms.FlowLayoutPanel LeftColumn;
        private System.Windows.Forms.Label lblFirstNumber;
        private System.Windows.Forms.NumericUpDown numFirst;
        private System.Windows.Forms.Label lblSecondNumber;
        private System.Windows.Forms.NumericUpDown numSecond;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblCalculatedResult;
        private System.Windows.Forms.FlowLayoutPanel RightColumn;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnDiff;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.ErrorProvider errValidator;
    }
}

