
namespace DagoApp_
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.home = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.empresas = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.cobradores = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.clientes = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.prestamos = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.reporteria = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rptEgresos = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rptIngresos = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ayuda = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.about = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.aboutApp = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.configuracion = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.BackColor = System.Drawing.Color.Silver;
            this.ribbonControl1.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(26, 30, 26, 30);
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.barButtonItem1,
            this.barStaticItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 3;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsMenuMinWidth = 289;
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.home,
            this.empresas,
            this.cobradores,
            this.clientes,
            this.prestamos,
            this.reporteria,
            this.ayuda,
            this.configuracion});
            this.ribbonControl1.Size = new System.Drawing.Size(1158, 193);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Empresas";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // home
            // 
            this.home.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.home.Name = "home";
            this.home.Text = "Inicio";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // empresas
            // 
            this.empresas.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.empresas.Name = "empresas";
            this.empresas.Text = "Empresas";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPageGroup2.ImageOptions.Image")));
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // cobradores
            // 
            this.cobradores.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.cobradores.Name = "cobradores";
            this.cobradores.Text = "Cobradores";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "ribbonPageGroup3";
            // 
            // clientes
            // 
            this.clientes.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.clientes.Name = "clientes";
            this.clientes.Text = "Clientes";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "ribbonPageGroup4";
            // 
            // prestamos
            // 
            this.prestamos.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5});
            this.prestamos.Name = "prestamos";
            this.prestamos.Text = "Préstamos";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "ribbonPageGroup5";
            // 
            // reporteria
            // 
            this.reporteria.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rptEgresos,
            this.rptIngresos});
            this.reporteria.Name = "reporteria";
            this.reporteria.Text = "Reportes";
            // 
            // rptEgresos
            // 
            this.rptEgresos.Name = "rptEgresos";
            this.rptEgresos.Text = "Clientes Egresados";
            // 
            // rptIngresos
            // 
            this.rptIngresos.Name = "rptIngresos";
            this.rptIngresos.Text = "Clientes Ingresados";
            // 
            // ayuda
            // 
            this.ayuda.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.about,
            this.aboutApp});
            this.ayuda.Name = "ayuda";
            this.ayuda.Text = "Ayuda";
            // 
            // about
            // 
            this.about.Name = "about";
            this.about.Text = "Acerca de";
            // 
            // aboutApp
            // 
            this.aboutApp.Name = "aboutApp";
            this.aboutApp.Text = "Ayuda";
            // 
            // configuracion
            // 
            this.configuracion.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup7});
            this.configuracion.Name = "configuracion";
            this.configuracion.Text = "Configuración";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            this.ribbonPageGroup7.Text = "ribbonPageGroup7";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.ItemLinks.Add(this.barStaticItem1);
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 819);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1158, 30);
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barStaticItem1.Caption = "DomChrisApp\r\n";
            this.barStaticItem1.Id = 2;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(1158, 849);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("Main.IconOptions.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.Ribbon = this.ribbonControl1;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "PRESTAPP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage home;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage empresas;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage cobradores;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPage clientes;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPage prestamos;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPage reporteria;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rptEgresos;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rptIngresos;
        private DevExpress.XtraBars.Ribbon.RibbonPage ayuda;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup about;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup aboutApp;
        private DevExpress.XtraBars.Ribbon.RibbonPage configuracion;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
    }
}

