namespace ImageProcessing
{
    partial class Form1
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
            this.btnBrowse = new System.Windows.Forms.Button();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.btnNegative = new System.Windows.Forms.Button();
            this.btnLighten = new System.Windows.Forms.Button();
            this.btnDarken = new System.Windows.Forms.Button();
            this.btnSunset_Effect = new System.Windows.Forms.Button();
            this.btnPolarize = new System.Windows.Forms.Button();
            this.btngray_scale = new System.Windows.Forms.Button();
            this.btnGreen = new System.Windows.Forms.Button();
            this.btnRed = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.btnHorizontalFlip = new System.Windows.Forms.Button();
            this.btnFlipvertically = new System.Windows.Forms.Button();
            this.btnRotate = new System.Windows.Forms.Button();
            this.btnBlur = new System.Windows.Forms.Button();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.btn_sortred = new System.Windows.Forms.Button();
            this.btnscrolldown = new System.Windows.Forms.Button();
            this.btnScrollUp = new System.Windows.Forms.Button();
            this.btnpixellate = new System.Windows.Forms.Button();
            this.btnTile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(64, 447);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(390, 59);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // picImage
            // 
            this.picImage.Location = new System.Drawing.Point(13, 45);
            this.picImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(480, 369);
            this.picImage.TabIndex = 3;
            this.picImage.TabStop = false;
            // 
            // btnNegative
            // 
            this.btnNegative.Location = new System.Drawing.Point(695, 132);
            this.btnNegative.Name = "btnNegative";
            this.btnNegative.Size = new System.Drawing.Size(108, 54);
            this.btnNegative.TabIndex = 6;
            this.btnNegative.Text = "Negative";
            this.btnNegative.UseVisualStyleBackColor = true;
            this.btnNegative.Click += new System.EventHandler(this.btnNegative_Click);
            // 
            // btnLighten
            // 
            this.btnLighten.Location = new System.Drawing.Point(536, 45);
            this.btnLighten.Name = "btnLighten";
            this.btnLighten.Size = new System.Drawing.Size(108, 54);
            this.btnLighten.TabIndex = 7;
            this.btnLighten.Text = "Lighten";
            this.btnLighten.UseVisualStyleBackColor = true;
            this.btnLighten.Click += new System.EventHandler(this.btnLighten_Click);
            // 
            // btnDarken
            // 
            this.btnDarken.Location = new System.Drawing.Point(695, 45);
            this.btnDarken.Name = "btnDarken";
            this.btnDarken.Size = new System.Drawing.Size(108, 54);
            this.btnDarken.TabIndex = 8;
            this.btnDarken.Text = "Darken";
            this.btnDarken.UseVisualStyleBackColor = true;
            this.btnDarken.Click += new System.EventHandler(this.btnDarken_Click);
            // 
            // btnSunset_Effect
            // 
            this.btnSunset_Effect.Location = new System.Drawing.Point(849, 45);
            this.btnSunset_Effect.Name = "btnSunset_Effect";
            this.btnSunset_Effect.Size = new System.Drawing.Size(108, 54);
            this.btnSunset_Effect.TabIndex = 9;
            this.btnSunset_Effect.Text = "Sunset Effect";
            this.btnSunset_Effect.UseVisualStyleBackColor = true;
            this.btnSunset_Effect.Click += new System.EventHandler(this.btnSunset_Effect_Click);
            // 
            // btnPolarize
            // 
            this.btnPolarize.Location = new System.Drawing.Point(849, 132);
            this.btnPolarize.Name = "btnPolarize";
            this.btnPolarize.Size = new System.Drawing.Size(108, 54);
            this.btnPolarize.TabIndex = 10;
            this.btnPolarize.Text = "Polarize";
            this.btnPolarize.UseVisualStyleBackColor = true;
            this.btnPolarize.Click += new System.EventHandler(this.btnPolarize_Click);
            // 
            // btngray_scale
            // 
            this.btngray_scale.Location = new System.Drawing.Point(536, 132);
            this.btngray_scale.Name = "btngray_scale";
            this.btngray_scale.Size = new System.Drawing.Size(108, 54);
            this.btngray_scale.TabIndex = 11;
            this.btngray_scale.Text = "Gray Scale";
            this.btngray_scale.UseVisualStyleBackColor = true;
            this.btngray_scale.Click += new System.EventHandler(this.btngray_scale_Click);
            // 
            // btnGreen
            // 
            this.btnGreen.Location = new System.Drawing.Point(695, 225);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(108, 54);
            this.btnGreen.TabIndex = 12;
            this.btnGreen.Text = "Green";
            this.btnGreen.UseVisualStyleBackColor = true;
            this.btnGreen.Click += new System.EventHandler(this.btnGreen_Click);
            // 
            // btnRed
            // 
            this.btnRed.Location = new System.Drawing.Point(536, 225);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(108, 54);
            this.btnRed.TabIndex = 13;
            this.btnRed.Text = "Red";
            this.btnRed.UseVisualStyleBackColor = true;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // btnBlue
            // 
            this.btnBlue.Location = new System.Drawing.Point(849, 225);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(108, 54);
            this.btnBlue.TabIndex = 14;
            this.btnBlue.Text = "Blue";
            this.btnBlue.UseVisualStyleBackColor = true;
            this.btnBlue.Click += new System.EventHandler(this.btnBlue_Click);
            // 
            // btnHorizontalFlip
            // 
            this.btnHorizontalFlip.Location = new System.Drawing.Point(536, 327);
            this.btnHorizontalFlip.Name = "btnHorizontalFlip";
            this.btnHorizontalFlip.Size = new System.Drawing.Size(108, 54);
            this.btnHorizontalFlip.TabIndex = 15;
            this.btnHorizontalFlip.Text = "Flip Horizontally";
            this.btnHorizontalFlip.UseVisualStyleBackColor = true;
            this.btnHorizontalFlip.Click += new System.EventHandler(this.btnHorizontalFlip_Click);
            // 
            // btnFlipvertically
            // 
            this.btnFlipvertically.Location = new System.Drawing.Point(695, 327);
            this.btnFlipvertically.Name = "btnFlipvertically";
            this.btnFlipvertically.Size = new System.Drawing.Size(108, 54);
            this.btnFlipvertically.TabIndex = 16;
            this.btnFlipvertically.Text = "Flip Vertically";
            this.btnFlipvertically.UseVisualStyleBackColor = true;
            this.btnFlipvertically.Click += new System.EventHandler(this.btnFlipvertically_Click);
            // 
            // btnRotate
            // 
            this.btnRotate.Location = new System.Drawing.Point(849, 327);
            this.btnRotate.Name = "btnRotate";
            this.btnRotate.Size = new System.Drawing.Size(108, 54);
            this.btnRotate.TabIndex = 17;
            this.btnRotate.Text = "Rotate ";
            this.btnRotate.UseVisualStyleBackColor = true;
            this.btnRotate.Click += new System.EventHandler(this.btnRotate_Click);
            // 
            // btnBlur
            // 
            this.btnBlur.Location = new System.Drawing.Point(536, 421);
            this.btnBlur.Name = "btnBlur";
            this.btnBlur.Size = new System.Drawing.Size(108, 50);
            this.btnBlur.TabIndex = 18;
            this.btnBlur.Text = "Blur";
            this.btnBlur.UseVisualStyleBackColor = true;
            this.btnBlur.Click += new System.EventHandler(this.btnBlur_Click);
            // 
            // btnSwitch
            // 
            this.btnSwitch.Location = new System.Drawing.Point(695, 421);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(108, 50);
            this.btnSwitch.TabIndex = 19;
            this.btnSwitch.Text = "Switch";
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // btn_sortred
            // 
            this.btn_sortred.Location = new System.Drawing.Point(849, 421);
            this.btn_sortred.Name = "btn_sortred";
            this.btn_sortred.Size = new System.Drawing.Size(106, 54);
            this.btn_sortred.TabIndex = 20;
            this.btn_sortred.Text = "Sort";
            this.btn_sortred.UseVisualStyleBackColor = true;
            this.btn_sortred.Click += new System.EventHandler(this.btn_sortred_Click);
            // 
            // btnscrolldown
            // 
            this.btnscrolldown.Location = new System.Drawing.Point(696, 506);
            this.btnscrolldown.Name = "btnscrolldown";
            this.btnscrolldown.Size = new System.Drawing.Size(107, 54);
            this.btnscrolldown.TabIndex = 21;
            this.btnscrolldown.Text = "Scroll Down";
            this.btnscrolldown.UseVisualStyleBackColor = true;
            this.btnscrolldown.Click += new System.EventHandler(this.btnscrolldown_Click);
            // 
            // btnScrollUp
            // 
            this.btnScrollUp.Location = new System.Drawing.Point(531, 516);
            this.btnScrollUp.Name = "btnScrollUp";
            this.btnScrollUp.Size = new System.Drawing.Size(113, 54);
            this.btnScrollUp.TabIndex = 22;
            this.btnScrollUp.Text = "Scroll Up";
            this.btnScrollUp.UseVisualStyleBackColor = true;
            this.btnScrollUp.Click += new System.EventHandler(this.btnScrollUp_Click);
            // 
            // btnpixellate
            // 
            this.btnpixellate.Location = new System.Drawing.Point(849, 516);
            this.btnpixellate.Name = "btnpixellate";
            this.btnpixellate.Size = new System.Drawing.Size(106, 44);
            this.btnpixellate.TabIndex = 23;
            this.btnpixellate.Text = "Pixellate";
            this.btnpixellate.UseVisualStyleBackColor = true;
            this.btnpixellate.Click += new System.EventHandler(this.btnpixellate_Click);
            // 
            // btnTile
            // 
            this.btnTile.Location = new System.Drawing.Point(64, 537);
            this.btnTile.Name = "btnTile";
            this.btnTile.Size = new System.Drawing.Size(111, 56);
            this.btnTile.TabIndex = 24;
            this.btnTile.Text = "Tile";
            this.btnTile.UseVisualStyleBackColor = true;
            this.btnTile.Click += new System.EventHandler(this.btnTile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 614);
            this.Controls.Add(this.btnTile);
            this.Controls.Add(this.btnpixellate);
            this.Controls.Add(this.btnScrollUp);
            this.Controls.Add(this.btnscrolldown);
            this.Controls.Add(this.btn_sortred);
            this.Controls.Add(this.btnSwitch);
            this.Controls.Add(this.btnBlur);
            this.Controls.Add(this.btnRotate);
            this.Controls.Add(this.btnFlipvertically);
            this.Controls.Add(this.btnHorizontalFlip);
            this.Controls.Add(this.btnBlue);
            this.Controls.Add(this.btnRed);
            this.Controls.Add(this.btnGreen);
            this.Controls.Add(this.btngray_scale);
            this.Controls.Add(this.btnPolarize);
            this.Controls.Add(this.btnSunset_Effect);
            this.Controls.Add(this.btnDarken);
            this.Controls.Add(this.btnLighten);
            this.Controls.Add(this.btnNegative);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.picImage);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Image Processing";
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.Button btnNegative;
        private System.Windows.Forms.Button btnLighten;
        private System.Windows.Forms.Button btnDarken;
        private System.Windows.Forms.Button btnSunset_Effect;
        private System.Windows.Forms.Button btnPolarize;
        private System.Windows.Forms.Button btngray_scale;
        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.Button btnHorizontalFlip;
        private System.Windows.Forms.Button btnFlipvertically;
        private System.Windows.Forms.Button btnRotate;
        private System.Windows.Forms.Button btnBlur;
        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.Button btn_sortred;
        private System.Windows.Forms.Button btnscrolldown;
        private System.Windows.Forms.Button btnScrollUp;
        private System.Windows.Forms.Button btnpixellate;
        private System.Windows.Forms.Button btnTile;
    }
}

