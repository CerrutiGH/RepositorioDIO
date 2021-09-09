
namespace StarWarsWF.Screens
{
    partial class ControlNaves
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtNave = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscarNav = new System.Windows.Forms.Button();
            this.btnBuscarPiloto = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPiloto = new System.Windows.Forms.TextBox();
            this.dgvNaves = new System.Windows.Forms.DataGridView();
            this.dgvPilotos = new System.Windows.Forms.DataGridView();
            this.rbtChegando = new System.Windows.Forms.RadioButton();
            this.rbtSaindo = new System.Windows.Forms.RadioButton();
            this.btnNext = new System.Windows.Forms.Button();
            this.estrelaDaMorteDataSet = new StarWarsWF.EstrelaDaMorteDataSet();
            this.navesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.navesTableAdapter = new StarWarsWF.EstrelaDaMorteDataSetTableAdapters.NavesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNaves)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPilotos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estrelaDaMorteDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNave
            // 
            this.txtNave.Location = new System.Drawing.Point(208, 21);
            this.txtNave.Name = "txtNave";
            this.txtNave.Size = new System.Drawing.Size(336, 20);
            this.txtNave.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Naves";
            // 
            // btnBuscarNav
            // 
            this.btnBuscarNav.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarNav.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnBuscarNav.FlatAppearance.BorderSize = 3;
            this.btnBuscarNav.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnBuscarNav.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBuscarNav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarNav.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarNav.ForeColor = System.Drawing.Color.Yellow;
            this.btnBuscarNav.Location = new System.Drawing.Point(564, 16);
            this.btnBuscarNav.Name = "btnBuscarNav";
            this.btnBuscarNav.Size = new System.Drawing.Size(70, 30);
            this.btnBuscarNav.TabIndex = 3;
            this.btnBuscarNav.Text = "Buscar";
            this.btnBuscarNav.UseVisualStyleBackColor = false;
            this.btnBuscarNav.Click += new System.EventHandler(this.btnBuscarNave_Click);
            // 
            // btnBuscarPiloto
            // 
            this.btnBuscarPiloto.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarPiloto.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnBuscarPiloto.FlatAppearance.BorderSize = 3;
            this.btnBuscarPiloto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnBuscarPiloto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBuscarPiloto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPiloto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPiloto.ForeColor = System.Drawing.Color.Yellow;
            this.btnBuscarPiloto.Location = new System.Drawing.Point(564, 228);
            this.btnBuscarPiloto.Name = "btnBuscarPiloto";
            this.btnBuscarPiloto.Size = new System.Drawing.Size(70, 29);
            this.btnBuscarPiloto.TabIndex = 6;
            this.btnBuscarPiloto.Text = "Buscar";
            this.btnBuscarPiloto.UseVisualStyleBackColor = false;
            this.btnBuscarPiloto.Click += new System.EventHandler(this.btnBuscarPiloto_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(159, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pilotos";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtPiloto
            // 
            this.txtPiloto.Location = new System.Drawing.Point(208, 233);
            this.txtPiloto.Name = "txtPiloto";
            this.txtPiloto.Size = new System.Drawing.Size(336, 20);
            this.txtPiloto.TabIndex = 4;
            this.txtPiloto.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // dgvNaves
            // 
            this.dgvNaves.AllowUserToAddRows = false;
            this.dgvNaves.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Empty;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Empty;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNaves.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNaves.BackgroundColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNaves.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNaves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNaves.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvNaves.GridColor = System.Drawing.Color.Yellow;
            this.dgvNaves.Location = new System.Drawing.Point(208, 52);
            this.dgvNaves.Name = "dgvNaves";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNaves.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvNaves.Size = new System.Drawing.Size(426, 135);
            this.dgvNaves.TabIndex = 7;
            // 
            // dgvPilotos
            // 
            this.dgvPilotos.AllowUserToAddRows = false;
            this.dgvPilotos.AllowUserToDeleteRows = false;
            this.dgvPilotos.BackgroundColor = System.Drawing.Color.Black;
            this.dgvPilotos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPilotos.GridColor = System.Drawing.Color.Yellow;
            this.dgvPilotos.Location = new System.Drawing.Point(208, 263);
            this.dgvPilotos.Name = "dgvPilotos";
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            this.dgvPilotos.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPilotos.Size = new System.Drawing.Size(426, 135);
            this.dgvPilotos.TabIndex = 8;
            // 
            // rbtChegando
            // 
            this.rbtChegando.AutoSize = true;
            this.rbtChegando.BackColor = System.Drawing.Color.Transparent;
            this.rbtChegando.Location = new System.Drawing.Point(208, 407);
            this.rbtChegando.Name = "rbtChegando";
            this.rbtChegando.Size = new System.Drawing.Size(74, 17);
            this.rbtChegando.TabIndex = 9;
            this.rbtChegando.TabStop = true;
            this.rbtChegando.Text = "Chegando";
            this.rbtChegando.UseVisualStyleBackColor = false;
            // 
            // rbtSaindo
            // 
            this.rbtSaindo.AutoSize = true;
            this.rbtSaindo.BackColor = System.Drawing.Color.Transparent;
            this.rbtSaindo.Location = new System.Drawing.Point(310, 407);
            this.rbtSaindo.Name = "rbtSaindo";
            this.rbtSaindo.Size = new System.Drawing.Size(58, 17);
            this.rbtSaindo.TabIndex = 10;
            this.rbtSaindo.TabStop = true;
            this.rbtSaindo.Text = "Saindo";
            this.rbtSaindo.UseVisualStyleBackColor = false;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnNext.FlatAppearance.BorderSize = 3;
            this.btnNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.Yellow;
            this.btnNext.Location = new System.Drawing.Point(693, 400);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(73, 29);
            this.btnNext.TabIndex = 11;
            this.btnNext.Text = "Avançar";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // estrelaDaMorteDataSet
            // 
            this.estrelaDaMorteDataSet.DataSetName = "EstrelaDaMorteDataSet";
            this.estrelaDaMorteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // navesBindingSource
            // 
            this.navesBindingSource.DataMember = "Naves";
            this.navesBindingSource.DataSource = this.estrelaDaMorteDataSet;
            // 
            // navesTableAdapter
            // 
            this.navesTableAdapter.ClearBeforeFill = true;
            // 
            // ControlNaves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::StarWarsWF.Properties.Resources.ControlNaves;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.rbtSaindo);
            this.Controls.Add(this.rbtChegando);
            this.Controls.Add(this.dgvPilotos);
            this.Controls.Add(this.dgvNaves);
            this.Controls.Add(this.btnBuscarPiloto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPiloto);
            this.Controls.Add(this.btnBuscarNav);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNave);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "ControlNaves";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ControlNaves";
            this.Load += new System.EventHandler(this.ControlNaves_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNaves)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPilotos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estrelaDaMorteDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarNav;
        private System.Windows.Forms.Button btnBuscarPiloto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPiloto;
        private System.Windows.Forms.DataGridView dgvNaves;
        private System.Windows.Forms.DataGridView dgvPilotos;
        private System.Windows.Forms.RadioButton rbtChegando;
        private System.Windows.Forms.RadioButton rbtSaindo;
        private System.Windows.Forms.Button btnNext;
        private EstrelaDaMorteDataSet estrelaDaMorteDataSet;
        private System.Windows.Forms.BindingSource navesBindingSource;
        private EstrelaDaMorteDataSetTableAdapters.NavesTableAdapter navesTableAdapter;
    }
}