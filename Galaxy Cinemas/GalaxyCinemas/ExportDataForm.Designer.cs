namespace GalaxyCinemas
{
    partial class ExportDataForm
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
            this.btnSelectExportMovies = new System.Windows.Forms.Button();
            this.btnExportMoviesStart = new System.Windows.Forms.Button();
            this.btnMovieExportStop = new System.Windows.Forms.Button();
            this.txtFileMovie = new System.Windows.Forms.TextBox();
            this.btnSelectExportSessions = new System.Windows.Forms.Button();
            this.btnExportSessionsStart = new System.Windows.Forms.Button();
            this.btnExportSessionStop = new System.Windows.Forms.Button();
            this.txtFileSession = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.blSaveLoc = new System.Windows.Forms.Label();
            this.txtFileBooking = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelectExportMovies
            // 
            this.btnSelectExportMovies.Location = new System.Drawing.Point(38, 381);
            this.btnSelectExportMovies.Name = "btnSelectExportMovies";
            this.btnSelectExportMovies.Size = new System.Drawing.Size(179, 23);
            this.btnSelectExportMovies.TabIndex = 0;
            this.btnSelectExportMovies.Text = "Select File for Exporting Movies";
            this.btnSelectExportMovies.UseVisualStyleBackColor = true;
            this.btnSelectExportMovies.Visible = false;
            // 
            // btnExportMoviesStart
            // 
            this.btnExportMoviesStart.Location = new System.Drawing.Point(38, 436);
            this.btnExportMoviesStart.Name = "btnExportMoviesStart";
            this.btnExportMoviesStart.Size = new System.Drawing.Size(75, 23);
            this.btnExportMoviesStart.TabIndex = 1;
            this.btnExportMoviesStart.Text = "Start";
            this.btnExportMoviesStart.UseVisualStyleBackColor = true;
            this.btnExportMoviesStart.Visible = false;
            // 
            // btnMovieExportStop
            // 
            this.btnMovieExportStop.Location = new System.Drawing.Point(38, 436);
            this.btnMovieExportStop.Name = "btnMovieExportStop";
            this.btnMovieExportStop.Size = new System.Drawing.Size(75, 23);
            this.btnMovieExportStop.TabIndex = 2;
            this.btnMovieExportStop.Text = "Stop";
            this.btnMovieExportStop.UseVisualStyleBackColor = true;
            this.btnMovieExportStop.Visible = false;
            // 
            // txtFileMovie
            // 
            this.txtFileMovie.Location = new System.Drawing.Point(38, 410);
            this.txtFileMovie.Name = "txtFileMovie";
            this.txtFileMovie.Size = new System.Drawing.Size(242, 20);
            this.txtFileMovie.TabIndex = 3;
            this.txtFileMovie.Visible = false;
            // 
            // btnSelectExportSessions
            // 
            this.btnSelectExportSessions.Location = new System.Drawing.Point(38, 498);
            this.btnSelectExportSessions.Name = "btnSelectExportSessions";
            this.btnSelectExportSessions.Size = new System.Drawing.Size(179, 23);
            this.btnSelectExportSessions.TabIndex = 4;
            this.btnSelectExportSessions.Text = "Select File for Exporting Sessions";
            this.btnSelectExportSessions.UseVisualStyleBackColor = true;
            this.btnSelectExportSessions.Visible = false;
            // 
            // btnExportSessionsStart
            // 
            this.btnExportSessionsStart.Location = new System.Drawing.Point(38, 553);
            this.btnExportSessionsStart.Name = "btnExportSessionsStart";
            this.btnExportSessionsStart.Size = new System.Drawing.Size(75, 23);
            this.btnExportSessionsStart.TabIndex = 5;
            this.btnExportSessionsStart.Text = "Start";
            this.btnExportSessionsStart.UseVisualStyleBackColor = true;
            this.btnExportSessionsStart.Visible = false;
            // 
            // btnExportSessionStop
            // 
            this.btnExportSessionStop.Location = new System.Drawing.Point(38, 553);
            this.btnExportSessionStop.Name = "btnExportSessionStop";
            this.btnExportSessionStop.Size = new System.Drawing.Size(75, 23);
            this.btnExportSessionStop.TabIndex = 6;
            this.btnExportSessionStop.Text = "Stop";
            this.btnExportSessionStop.UseVisualStyleBackColor = true;
            this.btnExportSessionStop.Visible = false;
            // 
            // txtFileSession
            // 
            this.txtFileSession.Location = new System.Drawing.Point(38, 527);
            this.txtFileSession.Name = "txtFileSession";
            this.txtFileSession.Size = new System.Drawing.Size(242, 20);
            this.txtFileSession.TabIndex = 7;
            this.txtFileSession.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(322, 419);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.Visible = false;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(322, 527);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 9;
            this.dateTimePicker2.Visible = false;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "xml";
            this.saveFileDialog.Filter = "XML|*.xml";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(58, 70);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(200, 20);
            this.dtpFrom.TabIndex = 10;
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(374, 70);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(200, 20);
            this.dtpTo.TabIndex = 11;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(12, 70);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(33, 13);
            this.lblFrom.TabIndex = 12;
            this.lblFrom.Text = "From:";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(324, 70);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(23, 13);
            this.lblTo.TabIndex = 13;
            this.lblTo.Text = "To:";
            // 
            // blSaveLoc
            // 
            this.blSaveLoc.AutoSize = true;
            this.blSaveLoc.Location = new System.Drawing.Point(12, 23);
            this.blSaveLoc.Name = "blSaveLoc";
            this.blSaveLoc.Size = new System.Drawing.Size(79, 13);
            this.blSaveLoc.TabIndex = 14;
            this.blSaveLoc.Text = "Save Location:";
            // 
            // txtFileBooking
            // 
            this.txtFileBooking.Location = new System.Drawing.Point(98, 23);
            this.txtFileBooking.Name = "txtFileBooking";
            this.txtFileBooking.Size = new System.Drawing.Size(336, 20);
            this.txtFileBooking.TabIndex = 15;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(455, 19);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(119, 23);
            this.btnBrowse.TabIndex = 16;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(15, 139);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(119, 23);
            this.btnExport.TabIndex = 17;
            this.btnExport.Text = "Export Bookings";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(455, 139);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(119, 23);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ExportDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(612, 185);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtFileBooking);
            this.Controls.Add(this.blSaveLoc);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtFileSession);
            this.Controls.Add(this.btnExportSessionStop);
            this.Controls.Add(this.btnExportSessionsStart);
            this.Controls.Add(this.btnSelectExportSessions);
            this.Controls.Add(this.txtFileMovie);
            this.Controls.Add(this.btnMovieExportStop);
            this.Controls.Add(this.btnExportMoviesStart);
            this.Controls.Add(this.btnSelectExportMovies);
            this.Name = "ExportDataForm";
            this.Text = "Export Data";
            this.Load += new System.EventHandler(this.ExportDataForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectExportMovies;
        private System.Windows.Forms.Button btnExportMoviesStart;
        private System.Windows.Forms.Button btnMovieExportStop;
        private System.Windows.Forms.TextBox txtFileMovie;
        private System.Windows.Forms.Button btnSelectExportSessions;
        private System.Windows.Forms.Button btnExportSessionsStart;
        private System.Windows.Forms.Button btnExportSessionStop;
        private System.Windows.Forms.TextBox txtFileSession;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label blSaveLoc;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtFileBooking;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnExport;
    }
}