﻿
namespace Capa_Vista_Comisiones
{
    partial class Frm_Comisiones
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
            this.Gpb_ayuda = new System.Windows.Forms.GroupBox();
            this.Cbo_vendedor = new System.Windows.Forms.ComboBox();
            this.Lbl_vendedor = new System.Windows.Forms.Label();
            this.Gpb_limpiar = new System.Windows.Forms.GroupBox();
            this.Txt_porcentaje = new System.Windows.Forms.TextBox();
            this.Lbl_comision = new System.Windows.Forms.Label();
            this.Txt_nombre = new System.Windows.Forms.TextBox();
            this.Dgv_ventas = new System.Windows.Forms.DataGridView();
            this.Gpb_ventas = new System.Windows.Forms.GroupBox();
            this.Lbl_filtro = new System.Windows.Forms.Label();
            this.Cbo_filtro = new System.Windows.Forms.ComboBox();
            this.Rdb_costo = new System.Windows.Forms.RadioButton();
            this.Rdb_lineas = new System.Windows.Forms.RadioButton();
            this.Rdb_inventario = new System.Windows.Forms.RadioButton();
            this.Rdb_marcas = new System.Windows.Forms.RadioButton();
            this.Dtp_fecha_fin = new System.Windows.Forms.DateTimePicker();
            this.Lbl_al = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Dtp_fecha_inicio = new System.Windows.Forms.DateTimePicker();
            this.Lbl_del = new System.Windows.Forms.Label();
            this.Gpb_calculo = new System.Windows.Forms.GroupBox();
            this.Btn_calcular = new System.Windows.Forms.Button();
            this.Lbl_venta = new System.Windows.Forms.Label();
            this.Txt_venta = new System.Windows.Forms.TextBox();
            this.Txt_comision = new System.Windows.Forms.TextBox();
            this.Lbl_total = new System.Windows.Forms.Label();
            this.Gpb_reporte = new System.Windows.Forms.GroupBox();
            this.Btn_reporte = new System.Windows.Forms.Button();
            this.Btn_ayuda = new System.Windows.Forms.Button();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.Btn_limpiar = new System.Windows.Forms.Button();
            this.Gpb_ayuda.SuspendLayout();
            this.Gpb_limpiar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ventas)).BeginInit();
            this.Gpb_ventas.SuspendLayout();
            this.Gpb_calculo.SuspendLayout();
            this.Gpb_reporte.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gpb_ayuda
            // 
            this.Gpb_ayuda.Controls.Add(this.Btn_ayuda);
            this.Gpb_ayuda.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_ayuda.Location = new System.Drawing.Point(774, 20);
            this.Gpb_ayuda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Gpb_ayuda.Name = "Gpb_ayuda";
            this.Gpb_ayuda.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Gpb_ayuda.Size = new System.Drawing.Size(123, 94);
            this.Gpb_ayuda.TabIndex = 70;
            this.Gpb_ayuda.TabStop = false;
            this.Gpb_ayuda.Text = "Ayudas:";
            // 
            // Cbo_vendedor
            // 
            this.Cbo_vendedor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_vendedor.FormattingEnabled = true;
            this.Cbo_vendedor.Location = new System.Drawing.Point(121, 205);
            this.Cbo_vendedor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Cbo_vendedor.Name = "Cbo_vendedor";
            this.Cbo_vendedor.Size = new System.Drawing.Size(214, 27);
            this.Cbo_vendedor.TabIndex = 69;
            // 
            // Lbl_vendedor
            // 
            this.Lbl_vendedor.AutoSize = true;
            this.Lbl_vendedor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_vendedor.Location = new System.Drawing.Point(48, 205);
            this.Lbl_vendedor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_vendedor.Name = "Lbl_vendedor";
            this.Lbl_vendedor.Size = new System.Drawing.Size(71, 19);
            this.Lbl_vendedor.TabIndex = 67;
            this.Lbl_vendedor.Text = "Vendedor:";
            this.Lbl_vendedor.Click += new System.EventHandler(this.Lbl_vendedor_Click);
            // 
            // Gpb_limpiar
            // 
            this.Gpb_limpiar.Controls.Add(this.Btn_limpiar);
            this.Gpb_limpiar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_limpiar.Location = new System.Drawing.Point(774, 144);
            this.Gpb_limpiar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Gpb_limpiar.Name = "Gpb_limpiar";
            this.Gpb_limpiar.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Gpb_limpiar.Size = new System.Drawing.Size(123, 94);
            this.Gpb_limpiar.TabIndex = 66;
            this.Gpb_limpiar.TabStop = false;
            this.Gpb_limpiar.Text = "Limpiar campos:";
            // 
            // Txt_porcentaje
            // 
            this.Txt_porcentaje.Enabled = false;
            this.Txt_porcentaje.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_porcentaje.Location = new System.Drawing.Point(837, 250);
            this.Txt_porcentaje.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Txt_porcentaje.Name = "Txt_porcentaje";
            this.Txt_porcentaje.Size = new System.Drawing.Size(61, 26);
            this.Txt_porcentaje.TabIndex = 65;
            // 
            // Lbl_comision
            // 
            this.Lbl_comision.AutoSize = true;
            this.Lbl_comision.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_comision.Location = new System.Drawing.Point(697, 257);
            this.Lbl_comision.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_comision.Name = "Lbl_comision";
            this.Lbl_comision.Size = new System.Drawing.Size(138, 19);
            this.Lbl_comision.TabIndex = 64;
            this.Lbl_comision.Text = "Porcentaje Comision:";
            // 
            // Txt_nombre
            // 
            this.Txt_nombre.Enabled = false;
            this.Txt_nombre.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_nombre.Location = new System.Drawing.Point(46, 243);
            this.Txt_nombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Txt_nombre.Name = "Txt_nombre";
            this.Txt_nombre.Size = new System.Drawing.Size(288, 26);
            this.Txt_nombre.TabIndex = 62;
            // 
            // Dgv_ventas
            // 
            this.Dgv_ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_ventas.Location = new System.Drawing.Point(46, 280);
            this.Dgv_ventas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Dgv_ventas.Name = "Dgv_ventas";
            this.Dgv_ventas.RowHeadersWidth = 51;
            this.Dgv_ventas.RowTemplate.Height = 24;
            this.Dgv_ventas.Size = new System.Drawing.Size(850, 154);
            this.Dgv_ventas.TabIndex = 61;
            // 
            // Gpb_ventas
            // 
            this.Gpb_ventas.Controls.Add(this.Lbl_filtro);
            this.Gpb_ventas.Controls.Add(this.Cbo_filtro);
            this.Gpb_ventas.Controls.Add(this.Rdb_costo);
            this.Gpb_ventas.Controls.Add(this.Rdb_lineas);
            this.Gpb_ventas.Controls.Add(this.Rdb_inventario);
            this.Gpb_ventas.Controls.Add(this.Rdb_marcas);
            this.Gpb_ventas.Controls.Add(this.Dtp_fecha_fin);
            this.Gpb_ventas.Controls.Add(this.Lbl_al);
            this.Gpb_ventas.Controls.Add(this.label2);
            this.Gpb_ventas.Controls.Add(this.Dtp_fecha_inicio);
            this.Gpb_ventas.Controls.Add(this.Lbl_del);
            this.Gpb_ventas.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_ventas.Location = new System.Drawing.Point(69, 20);
            this.Gpb_ventas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Gpb_ventas.Name = "Gpb_ventas";
            this.Gpb_ventas.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Gpb_ventas.Size = new System.Drawing.Size(700, 159);
            this.Gpb_ventas.TabIndex = 63;
            this.Gpb_ventas.TabStop = false;
            this.Gpb_ventas.Text = "Filtrar ventas por:";
            // 
            // Lbl_filtro
            // 
            this.Lbl_filtro.AutoSize = true;
            this.Lbl_filtro.Location = new System.Drawing.Point(174, 76);
            this.Lbl_filtro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_filtro.Name = "Lbl_filtro";
            this.Lbl_filtro.Size = new System.Drawing.Size(0, 19);
            this.Lbl_filtro.TabIndex = 18;
            // 
            // Cbo_filtro
            // 
            this.Cbo_filtro.FormattingEnabled = true;
            this.Cbo_filtro.Location = new System.Drawing.Point(277, 74);
            this.Cbo_filtro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Cbo_filtro.Name = "Cbo_filtro";
            this.Cbo_filtro.Size = new System.Drawing.Size(204, 27);
            this.Cbo_filtro.TabIndex = 17;
            // 
            // Rdb_costo
            // 
            this.Rdb_costo.AutoSize = true;
            this.Rdb_costo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rdb_costo.Location = new System.Drawing.Point(447, 37);
            this.Rdb_costo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Rdb_costo.Name = "Rdb_costo";
            this.Rdb_costo.Size = new System.Drawing.Size(131, 23);
            this.Rdb_costo.TabIndex = 16;
            this.Rdb_costo.TabStop = true;
            this.Rdb_costo.Text = "Basada en Costo";
            this.Rdb_costo.UseVisualStyleBackColor = true;
            // 
            // Rdb_lineas
            // 
            this.Rdb_lineas.AutoSize = true;
            this.Rdb_lineas.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rdb_lineas.Location = new System.Drawing.Point(380, 37);
            this.Rdb_lineas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Rdb_lineas.Name = "Rdb_lineas";
            this.Rdb_lineas.Size = new System.Drawing.Size(66, 23);
            this.Rdb_lineas.TabIndex = 15;
            this.Rdb_lineas.TabStop = true;
            this.Rdb_lineas.Text = "Lineas";
            this.Rdb_lineas.UseVisualStyleBackColor = true;
            // 
            // Rdb_inventario
            // 
            this.Rdb_inventario.AutoSize = true;
            this.Rdb_inventario.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rdb_inventario.Location = new System.Drawing.Point(220, 37);
            this.Rdb_inventario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Rdb_inventario.Name = "Rdb_inventario";
            this.Rdb_inventario.Size = new System.Drawing.Size(87, 23);
            this.Rdb_inventario.TabIndex = 14;
            this.Rdb_inventario.TabStop = true;
            this.Rdb_inventario.Text = "Inventario";
            this.Rdb_inventario.UseVisualStyleBackColor = true;
            // 
            // Rdb_marcas
            // 
            this.Rdb_marcas.AutoSize = true;
            this.Rdb_marcas.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rdb_marcas.Location = new System.Drawing.Point(308, 37);
            this.Rdb_marcas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Rdb_marcas.Name = "Rdb_marcas";
            this.Rdb_marcas.Size = new System.Drawing.Size(73, 23);
            this.Rdb_marcas.TabIndex = 13;
            this.Rdb_marcas.TabStop = true;
            this.Rdb_marcas.Text = "Marcas";
            this.Rdb_marcas.UseVisualStyleBackColor = true;
            // 
            // Dtp_fecha_fin
            // 
            this.Dtp_fecha_fin.CalendarFont = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_fecha_fin.Location = new System.Drawing.Point(408, 115);
            this.Dtp_fecha_fin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Dtp_fecha_fin.Name = "Dtp_fecha_fin";
            this.Dtp_fecha_fin.Size = new System.Drawing.Size(256, 26);
            this.Dtp_fecha_fin.TabIndex = 11;
            // 
            // Lbl_al
            // 
            this.Lbl_al.AutoSize = true;
            this.Lbl_al.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_al.Location = new System.Drawing.Point(378, 119);
            this.Lbl_al.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_al.Name = "Lbl_al";
            this.Lbl_al.Size = new System.Drawing.Size(19, 19);
            this.Lbl_al.TabIndex = 10;
            this.Lbl_al.Text = "al";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(123, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Comision por:";
            // 
            // Dtp_fecha_inicio
            // 
            this.Dtp_fecha_inicio.CalendarFont = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_fecha_inicio.Location = new System.Drawing.Point(110, 115);
            this.Dtp_fecha_inicio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Dtp_fecha_inicio.Name = "Dtp_fecha_inicio";
            this.Dtp_fecha_inicio.Size = new System.Drawing.Size(258, 26);
            this.Dtp_fecha_inicio.TabIndex = 9;
            // 
            // Lbl_del
            // 
            this.Lbl_del.AutoSize = true;
            this.Lbl_del.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_del.Location = new System.Drawing.Point(24, 119);
            this.Lbl_del.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_del.Name = "Lbl_del";
            this.Lbl_del.Size = new System.Drawing.Size(82, 19);
            this.Lbl_del.TabIndex = 7;
            this.Lbl_del.Text = "Periodo del:";
            // 
            // Gpb_calculo
            // 
            this.Gpb_calculo.Controls.Add(this.Btn_calcular);
            this.Gpb_calculo.Controls.Add(this.Lbl_venta);
            this.Gpb_calculo.Controls.Add(this.Txt_venta);
            this.Gpb_calculo.Controls.Add(this.Txt_comision);
            this.Gpb_calculo.Controls.Add(this.Lbl_total);
            this.Gpb_calculo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_calculo.Location = new System.Drawing.Point(546, 449);
            this.Gpb_calculo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Gpb_calculo.Name = "Gpb_calculo";
            this.Gpb_calculo.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Gpb_calculo.Size = new System.Drawing.Size(351, 101);
            this.Gpb_calculo.TabIndex = 71;
            this.Gpb_calculo.TabStop = false;
            this.Gpb_calculo.Text = "Calculo de Comision:";
            // 
            // Btn_calcular
            // 
            this.Btn_calcular.Location = new System.Drawing.Point(23, 40);
            this.Btn_calcular.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_calcular.Name = "Btn_calcular";
            this.Btn_calcular.Size = new System.Drawing.Size(68, 28);
            this.Btn_calcular.TabIndex = 19;
            this.Btn_calcular.Text = "Calcular";
            this.Btn_calcular.UseVisualStyleBackColor = true;
            // 
            // Lbl_venta
            // 
            this.Lbl_venta.AutoSize = true;
            this.Lbl_venta.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_venta.Location = new System.Drawing.Point(96, 24);
            this.Lbl_venta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_venta.Name = "Lbl_venta";
            this.Lbl_venta.Size = new System.Drawing.Size(111, 19);
            this.Lbl_venta.TabIndex = 47;
            this.Lbl_venta.Text = "Total de la venta:";
            // 
            // Txt_venta
            // 
            this.Txt_venta.Enabled = false;
            this.Txt_venta.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_venta.Location = new System.Drawing.Point(215, 21);
            this.Txt_venta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Txt_venta.Name = "Txt_venta";
            this.Txt_venta.Size = new System.Drawing.Size(116, 26);
            this.Txt_venta.TabIndex = 48;
            // 
            // Txt_comision
            // 
            this.Txt_comision.Enabled = false;
            this.Txt_comision.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_comision.Location = new System.Drawing.Point(215, 58);
            this.Txt_comision.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Txt_comision.Name = "Txt_comision";
            this.Txt_comision.Size = new System.Drawing.Size(116, 26);
            this.Txt_comision.TabIndex = 49;
            // 
            // Lbl_total
            // 
            this.Lbl_total.AutoSize = true;
            this.Lbl_total.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_total.Location = new System.Drawing.Point(112, 58);
            this.Lbl_total.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_total.Name = "Lbl_total";
            this.Lbl_total.Size = new System.Drawing.Size(96, 19);
            this.Lbl_total.TabIndex = 50;
            this.Lbl_total.Text = "Comsion total:";
            // 
            // Gpb_reporte
            // 
            this.Gpb_reporte.Controls.Add(this.Btn_reporte);
            this.Gpb_reporte.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_reporte.Location = new System.Drawing.Point(51, 444);
            this.Gpb_reporte.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Gpb_reporte.Name = "Gpb_reporte";
            this.Gpb_reporte.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Gpb_reporte.Size = new System.Drawing.Size(136, 106);
            this.Gpb_reporte.TabIndex = 72;
            this.Gpb_reporte.TabStop = false;
            this.Gpb_reporte.Text = "Generar Reporte:";
            // 
            // Btn_reporte
            // 
            this.Btn_reporte.FlatAppearance.BorderSize = 0;
            this.Btn_reporte.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_reporte.Image = global::Capa_Vista_Comisiones.Properties.Resources.reporte2;
            this.Btn_reporte.Location = new System.Drawing.Point(36, 32);
            this.Btn_reporte.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_reporte.Name = "Btn_reporte";
            this.Btn_reporte.Size = new System.Drawing.Size(53, 55);
            this.Btn_reporte.TabIndex = 52;
            this.Btn_reporte.UseVisualStyleBackColor = true;
            // 
            // Btn_ayuda
            // 
            this.Btn_ayuda.FlatAppearance.BorderSize = 0;
            this.Btn_ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_ayuda.Image = global::Capa_Vista_Comisiones.Properties.Resources.preguntas1;
            this.Btn_ayuda.Location = new System.Drawing.Point(35, 24);
            this.Btn_ayuda.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_ayuda.Name = "Btn_ayuda";
            this.Btn_ayuda.Size = new System.Drawing.Size(54, 55);
            this.Btn_ayuda.TabIndex = 53;
            this.Btn_ayuda.UseVisualStyleBackColor = true;
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.FlatAppearance.BorderSize = 0;
            this.Btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_buscar.Image = global::Capa_Vista_Comisiones.Properties.Resources.lista_de_verificacion;
            this.Btn_buscar.Location = new System.Drawing.Point(346, 194);
            this.Btn_buscar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(51, 55);
            this.Btn_buscar.TabIndex = 68;
            this.Btn_buscar.UseVisualStyleBackColor = true;
            // 
            // Btn_limpiar
            // 
            this.Btn_limpiar.FlatAppearance.BorderSize = 0;
            this.Btn_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_limpiar.Image = global::Capa_Vista_Comisiones.Properties.Resources.cancelar1;
            this.Btn_limpiar.Location = new System.Drawing.Point(35, 24);
            this.Btn_limpiar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_limpiar.Name = "Btn_limpiar";
            this.Btn_limpiar.Size = new System.Drawing.Size(54, 55);
            this.Btn_limpiar.TabIndex = 53;
            this.Btn_limpiar.UseVisualStyleBackColor = true;
            // 
            // Frm_Comisiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(247)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(950, 560);
            this.Controls.Add(this.Gpb_calculo);
            this.Controls.Add(this.Gpb_reporte);
            this.Controls.Add(this.Gpb_ayuda);
            this.Controls.Add(this.Cbo_vendedor);
            this.Controls.Add(this.Btn_buscar);
            this.Controls.Add(this.Lbl_vendedor);
            this.Controls.Add(this.Gpb_limpiar);
            this.Controls.Add(this.Txt_porcentaje);
            this.Controls.Add(this.Lbl_comision);
            this.Controls.Add(this.Txt_nombre);
            this.Controls.Add(this.Dgv_ventas);
            this.Controls.Add(this.Gpb_ventas);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Frm_Comisiones";
            this.Text = "Frm_Comisiones";
            this.Gpb_ayuda.ResumeLayout(false);
            this.Gpb_limpiar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ventas)).EndInit();
            this.Gpb_ventas.ResumeLayout(false);
            this.Gpb_ventas.PerformLayout();
            this.Gpb_calculo.ResumeLayout(false);
            this.Gpb_calculo.PerformLayout();
            this.Gpb_reporte.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Gpb_ayuda;
        private System.Windows.Forms.Button Btn_ayuda;
        private System.Windows.Forms.ComboBox Cbo_vendedor;
        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.Label Lbl_vendedor;
        private System.Windows.Forms.GroupBox Gpb_limpiar;
        private System.Windows.Forms.Button Btn_limpiar;
        private System.Windows.Forms.TextBox Txt_porcentaje;
        private System.Windows.Forms.Label Lbl_comision;
        private System.Windows.Forms.TextBox Txt_nombre;
        private System.Windows.Forms.DataGridView Dgv_ventas;
        private System.Windows.Forms.GroupBox Gpb_ventas;
        private System.Windows.Forms.Label Lbl_filtro;
        private System.Windows.Forms.ComboBox Cbo_filtro;
        private System.Windows.Forms.RadioButton Rdb_costo;
        private System.Windows.Forms.RadioButton Rdb_lineas;
        private System.Windows.Forms.RadioButton Rdb_inventario;
        private System.Windows.Forms.RadioButton Rdb_marcas;
        private System.Windows.Forms.DateTimePicker Dtp_fecha_fin;
        private System.Windows.Forms.Label Lbl_al;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker Dtp_fecha_inicio;
        private System.Windows.Forms.Label Lbl_del;
        private System.Windows.Forms.GroupBox Gpb_calculo;
        private System.Windows.Forms.Button Btn_calcular;
        private System.Windows.Forms.Label Lbl_venta;
        private System.Windows.Forms.TextBox Txt_venta;
        private System.Windows.Forms.TextBox Txt_comision;
        private System.Windows.Forms.Label Lbl_total;
        private System.Windows.Forms.GroupBox Gpb_reporte;
        private System.Windows.Forms.Button Btn_reporte;
    }
}