using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace OdontogramaLib
{
    public partial class DientesTotales : UserControl
    {

        System.Resources.ResourceManager Recursos = new System.Resources.ResourceManager(typeof(ConjuntoDeDientes));


        #region VariablesGlobales

        private Int32 _ValoresMaximos = 33333;
        private Int32 _NumeroDeDienteSelecionado = 11;

        private Int32 _Diente11 = 11111;
        private Int32 _Diente12 = 11111;
        private Int32 _Diente13 = 11111;
        private Int32 _Diente14 = 11111;
        private Int32 _Diente15 = 11111;
        private Int32 _Diente16 = 11111;
        private Int32 _Diente17 = 11111;
        private Int32 _Diente18 = 11111;


        private Int32 _Diente21 = 11111;
        private Int32 _Diente22 = 11111;
        private Int32 _Diente23 = 11111;
        private Int32 _Diente24 = 11111;
        private Int32 _Diente25 = 11111;
        private Int32 _Diente26 = 11111;
        private Int32 _Diente27 = 11111;
        private Int32 _Diente28 = 11111;


        private Int32 _Diente31 = 11111;
        private Int32 _Diente32 = 11111;
        private Int32 _Diente33 = 11111;
        private Int32 _Diente34 = 11111;
        private Int32 _Diente35 = 11111;
        private Int32 _Diente36 = 11111;
        private Int32 _Diente37 = 11111;
        private Int32 _Diente38 = 11111;


        private Int32 _Diente41 = 11111;
        private Int32 _Diente42 = 11111;
        private Int32 _Diente43 = 11111;
        private Int32 _Diente44 = 11111;
        private Int32 _Diente45 = 11111;
        private Int32 _Diente46 = 11111;
        private Int32 _Diente47 = 11111;
        private Int32 _Diente48 = 11111;
        #endregion 

        #region Establece La cantidad MAxima de el elemento del Diente
        [Description("Establece El estado del Diente")]
        [Localizable(true)]
        [Category("Configuracion del Estado Maximo")]
        [Browsable(true)]
        public virtual Int32 NivelDeImagen
        {
            get { return _ValoresMaximos; }
            set
            {
                if (value <= 0) value = 11111;//si se pretende poner 0 como nivel de cambio
                if (value != _ValoresMaximos)//si el valor actual de alguno de los estado revasa el nivel permitido
                {
                    if (_Diente11 > value) _Diente11 = 11111;
                    if (_Diente12 > value) _Diente11 = 11111;
                    if (_Diente13 > value) _Diente11 = 11111;
                    if (_Diente14 > value) _Diente11 = 11111;
                    if (_Diente15 > value) _Diente11 = 11111;
                    if (_Diente16 > value) _Diente11 = 11111;
                    if (_Diente17 > value) _Diente11 = 11111;
                    if (_Diente18 > value) _Diente11 = 11111;
                    if (_Diente21 > value) _Diente11 = 11111;
                    if (_Diente22 > value) _Diente11 = 11111;
                    if (_Diente23 > value) _Diente11 = 11111;
                    if (_Diente24 > value) _Diente11 = 11111;
                    if (_Diente25 > value) _Diente11 = 11111;
                    if (_Diente26 > value) _Diente11 = 11111;
                    if (_Diente27 > value) _Diente11 = 11111;
                    if (_Diente28 > value) _Diente11 = 11111;
                    if (_Diente31 > value) _Diente11 = 11111;
                    if (_Diente32 > value) _Diente11 = 11111;
                    if (_Diente33 > value) _Diente11 = 11111;
                    if (_Diente34 > value) _Diente11 = 11111;
                    if (_Diente35 > value) _Diente11 = 11111;
                    if (_Diente36 > value) _Diente11 = 11111;
                    if (_Diente37 > value) _Diente11 = 11111;
                    if (_Diente38 > value) _Diente11 = 11111;
                    if (_Diente41 > value) _Diente11 = 11111;
                    if (_Diente42 > value) _Diente11 = 11111;
                    if (_Diente43 > value) _Diente11 = 11111;
                    if (_Diente44 > value) _Diente11 = 11111;
                    if (_Diente45 > value) _Diente11 = 11111;
                    if (_Diente46 > value) _Diente11 = 11111;
                    if (_Diente47 > value) _Diente11 = 11111;
                    if (_Diente48 > value) _Diente11 = 11111;
                }
                _ValoresMaximos = value;

            }
        }

        #endregion 

        #region Dientes de la parte Lateral Deracha Superior 

        #region Diente 11
        [Description("Valor de el diente numero 11")]
        [Localizable(true)]
        [Category("Lateral Deracha Superior")]
        [Browsable(true)]

        public virtual Int32 DienteNumero11 {

            get { return _Diente11; }
            
            set {

                if ((value > NivelDeImagen) || (value <= 0))
                    value = 11111;

                _Diente11 = value; 
                
                try
                {
                    Diente11.Image = (Image)Recursos.GetObject("Estado" + _Diente11); 
                }
                catch { Diente11.Image = null;  }
            
            
            }
        
        
        }
        #endregion 

        #region Diente 12
        [Description("Valor de el diente numero 12")]
        [Localizable(true)]
        [Category("Lateral Deracha Superior")]
        [Browsable(true)]

        public virtual Int32 DienteNumero12
        {


            get { return _Diente12; }

            set
            {

                if ((value > NivelDeImagen) || (value <= 0))
                    value = 11111;

                _Diente12 = value;

                try
                {
                    Diente12.Image = (Image)Recursos.GetObject("Estado" + _Diente12);
                }
                catch { Diente12.Image = null; }


            }


        }
        #endregion 

        #region Diente 13
        [Description("Valor de el diente numero 13")]
        [Localizable(true)]
        [Category("Lateral Deracha Superior")]
        [Browsable(true)]

        public virtual Int32 DienteNumero13
        {

            get { return _Diente13; }

            set
            {

                if ((value > NivelDeImagen) || (value <= 0))
                    value = 11111;

                _Diente13 = value;

                try
                {
                    Diente13.Image = (Image)Recursos.GetObject("Estado" + _Diente13);
                }
                catch { Diente13.Image = null; }


            }


        }
        #endregion

        #region Diente 14
        [Description("Valor de el diente numero 14")]
        [Localizable(true)]
        [Category("Lateral Deracha Superior")]
        [Browsable(true)]

        public virtual Int32 DienteNumero14
        {


            get { return _Diente14; }

            set
            {

                if ((value > NivelDeImagen) || (value <= 0))
                    value = 11111;

                _Diente14 = value;

                try
                {
                    Diente14.Image = (Image)Recursos.GetObject("Estado" + _Diente14);
                }
                catch { Diente14.Image = null; }


            }


        }
        #endregion 

        #region Diente 15
        [Description("Valor de el diente numero 15")]
        [Localizable(true)]
        [Category("Lateral Deracha Superior")]
        [Browsable(true)]

        public virtual Int32 DienteNumero15
        {

            get { return _Diente15; }

            set
            {

                if ((value > NivelDeImagen) || (value <= 0))
                    value = 11111;

                _Diente15 = value;

                try
                {
                    Diente15.Image = (Image)Recursos.GetObject("Estado" + _Diente15);
                }
                catch { Diente15.Image = null; }


            }


        }
        #endregion

        #region Diente 16
        [Description("Valor de el diente numero 16")]
        [Localizable(true)]
        [Category("Lateral Deracha Superior")]
        [Browsable(true)]

        public virtual Int32 DienteNumero16
        {


            get { return _Diente16; }

            set
            {

                if ((value > NivelDeImagen) || (value <= 0))
                    value = 11111;

                _Diente16 = value;

                try
                {
                    Diente16.Image = (Image)Recursos.GetObject("Estado" + _Diente16);
                }
                catch { Diente16.Image = null; }


            }


        }
        #endregion

        #region Diente 17
        [Description("Valor de el diente numero 17")]
        [Localizable(true)]
        [Category("Lateral Deracha Superior")]
        [Browsable(true)]

        public virtual Int32 DienteNumero17
        {

            get { return _Diente17; }

            set
            {

                if ((value > NivelDeImagen) || (value <= 0))
                    value = 11111;

                _Diente17 = value;

                try
                {
                    Diente17.Image = (Image)Recursos.GetObject("Estado" + _Diente17);
                }
                catch { Diente17.Image = null; }


            }


        }
        #endregion

        #region Diente 18
        [Description("Valor de el diente numero 18")]
        [Localizable(true)]
        [Category("Lateral Deracha Superior")]
        [Browsable(true)]

        public virtual Int32 DienteNumero18
        {


            get { return _Diente18; }

            set
            {

                if ((value > NivelDeImagen) || (value <= 0))
                    value = 11111;

                _Diente18 = value;

                try
                {
                    Diente18.Image = (Image)Recursos.GetObject("Estado" + _Diente18);
                }
                catch { Diente18.Image = null; }


            }


        }
        #endregion 

        #endregion 

        #region Dientes de la parte Lateral Izquierda Superior

        #region Diente 21
        [Description("Valor de el diente numero 21")]
        [Localizable(true)]
        [Category("Lateral Izquierda Superior")]
        [Browsable(true)]

        public virtual Int32 DienteNumero21
        {

            get { return _Diente21; }

            set
            {

                if ((value > NivelDeImagen) || (value <= 0))
                    value = 11111;

                _Diente21 = value;

                try
                {
                    Diente21.Image = (Image)Recursos.GetObject("Estado" + _Diente21);
                }
                catch { Diente21.Image = null; }


            }


        }
        #endregion

        #region Diente 22
        [Description("Valor de el diente numero 22")]
        [Localizable(true)]
        [Category("Lateral Izquierda Superior")]
        [Browsable(true)]

        public virtual Int32 DienteNumero22
        {


            get { return _Diente22; }

            set
            {

                if ((value > NivelDeImagen) || (value <= 0))
                    value = 11111;

                _Diente22 = value;

                try
                {
                    Diente22.Image = (Image)Recursos.GetObject("Estado" + _Diente22);
                }
                catch { Diente22.Image = null; }


            }


        }
        #endregion

        #region Diente 23
        [Description("Valor de el diente numero 23")]
        [Localizable(true)]
        [Category("Lateral Izquierda Superior")]
        [Browsable(true)]

        public virtual Int32 DienteNumero23
        {

            get { return _Diente23; }

            set
            {

                if ((value > NivelDeImagen) || (value <= 0))
                    value = 11111;

                _Diente23 = value;

                try
                {
                    Diente23.Image = (Image)Recursos.GetObject("Estado" + _Diente23);
                }
                catch { Diente23.Image = null; }


            }


        }
        #endregion

        #region Diente 24
        [Description("Valor de el diente numero 24")]
        [Localizable(true)]
        [Category("Lateral Izquierda Superior")]
        [Browsable(true)]

        public virtual Int32 DienteNumero24
        {


            get { return _Diente24; }

            set
            {

                if ((value > NivelDeImagen) || (value <= 0))
                    value = 11111;

                _Diente24 = value;

                try
                {
                    Diente24.Image = (Image)Recursos.GetObject("Estado" + _Diente24);
                }
                catch { Diente24.Image = null; }


            }


        }
        #endregion

        #region Diente 25
        [Description("Valor de el diente numero 25")]
        [Localizable(true)]
        [Category("Lateral Izquierda Superior")]
        [Browsable(true)]

        public virtual Int32 DienteNumero25
        {

            get { return _Diente25; }

            set
            {

                if ((value > NivelDeImagen) || (value <= 0))
                    value = 11111;

                _Diente25 = value;

                try
                {
                    Diente25.Image = (Image)Recursos.GetObject("Estado" + _Diente25);
                }
                catch { Diente25.Image = null; }


            }


        }
        #endregion

        #region Diente 26
        [Description("Valor de el diente numero 26")]
        [Localizable(true)]
        [Category("Lateral Izquierda Superior")]
        [Browsable(true)]

        public virtual Int32 DienteNumero26
        {


            get { return _Diente26; }

            set
            {

                if ((value > NivelDeImagen) || (value <= 0))
                    value = 11111;

                _Diente26 = value;

                try
                {
                    Diente26.Image = (Image)Recursos.GetObject("Estado" + _Diente26);
                }
                catch { Diente26.Image = null; }


            }


        }
        #endregion

        #region Diente 27
        [Description("Valor de el diente numero 27")]
        [Localizable(true)]
        [Category("Lateral Izquierda Superior")]
        [Browsable(true)]

        public virtual Int32 DienteNumero27
        {

            get { return _Diente27; }

            set
            {

                if ((value > NivelDeImagen) || (value <= 0))
                    value = 11111;

                _Diente27 = value;

                try
                {
                    Diente27.Image = (Image)Recursos.GetObject("Estado" + _Diente27);
                }
                catch { Diente27.Image = null; }


            }


        }
        #endregion

        #region Diente 28
        [Description("Valor de el diente numero 28")]
        [Localizable(true)]
        [Category("Lateral Izquierda Superior")]
        [Browsable(true)]

        public virtual Int32 DienteNumero28
        {


            get { return _Diente28; }

            set
            {

                if ((value > NivelDeImagen) || (value <= 0))
                    value = 11111;

                _Diente28 = value;

                try
                {
                    Diente28.Image = (Image)Recursos.GetObject("Estado" + _Diente28);
                }
                catch { Diente28.Image = null; }


            }


        }
        #endregion

        #endregion 

        #region Dientes de la parte Lateral Deracha Inferior

        #region Diente 31
        [Description("Valor de el diente numero 31")]
        [Localizable(true)]
        [Category("Lateral Derecha Inferior")]
        [Browsable(true)]

        public virtual Int32 DienteNumero31
        {

            get { return _Diente31; }

            set
            {

                if ((value > NivelDeImagen) || (value <= 0))
                    value = 11111;

                _Diente31 = value;

                try
                {
                    Diente31.Image = (Image)Recursos.GetObject("Estado" + _Diente31);
                }
                catch { Diente31.Image = null; }


            }


        }
        #endregion

        #region Diente 32
        [Description("Valor de el diente numero 32")]
        [Localizable(true)]
        [Category("Lateral Derecha Inferior")]
        [Browsable(true)]

        public virtual Int32 DienteNumero32
        {


            get { return _Diente32; }

            set
            {

                if ((value > NivelDeImagen) || (value <= 0))
                    value = 11111;

                _Diente32 = value;

                try
                {
                    Diente32.Image = (Image)Recursos.GetObject("Estado" + _Diente32);
                }
                catch { Diente32.Image = null; }


            }


        }
        #endregion

        #region Diente 33
        [Description("Valor de el diente numero 33")]
        [Localizable(true)]
        [Category("Lateral Derecha Inferior")]
        [Browsable(true)]

        public virtual Int32 DienteNumero33
        {

            get { return _Diente33; }

            set
            {

                if ((value > NivelDeImagen) || (value <= 0))
                    value = 11111;

                _Diente33 = value;

                try
                {
                    Diente33.Image = (Image)Recursos.GetObject("Estado" + _Diente33);
                }
                catch { Diente33.Image = null; }


            }


        }
        #endregion

        #region Diente 34
        [Description("Valor de el diente numero 34")]
        [Localizable(true)]
        [Category("Lateral Derecha Inferior")]
        [Browsable(true)]

        public virtual Int32 DienteNumero34
        {


            get { return _Diente34; }

            set
            {

                if ((value > NivelDeImagen) || (value <= 0))
                    value = 11111;

                _Diente34 = value;

                try
                {
                    Diente34.Image = (Image)Recursos.GetObject("Estado" + _Diente34);
                }
                catch { Diente34.Image = null; }


            }


        }
        #endregion

        #region Diente 35
        [Description("Valor de el diente numero 35")]
        [Localizable(true)]
        [Category("Lateral Derecha Inferior")]
        [Browsable(true)]

        public virtual Int32 DienteNumero35
        {

            get { return _Diente35; }

            set
            {

                if ((value > NivelDeImagen) || (value <= 0))
                    value = 11111;

                _Diente35 = value;

                try
                {
                    Diente35.Image = (Image)Recursos.GetObject("Estado" + _Diente35);
                }
                catch { Diente35.Image = null; }


            }


        }
        #endregion

        #region Diente 36
        [Description("Valor de el diente numero 36")]
        [Localizable(true)]
        [Category("Lateral Derecha Inferior")]
        [Browsable(true)]

        public virtual Int32 DienteNumero36
        {


            get { return _Diente36; }

            set
            {

                if ((value > NivelDeImagen) || (value <= 0))
                    value = 11111;

                _Diente36 = value;

                try
                {
                    Diente36.Image = (Image)Recursos.GetObject("Estado" + _Diente36);
                }
                catch { Diente36.Image = null; }


            }


        }
        #endregion

        #region Diente 37
        [Description("Valor de el diente numero 37")]
        [Localizable(true)]
        [Category("Lateral Derecha Inferior")]
        [Browsable(true)]

        public virtual Int32 DienteNumero37
        {

            get { return _Diente37; }

            set
            {

                if ((value > NivelDeImagen) || (value <= 0))
                    value = 11111;

                _Diente37 = value;

                try
                {
                    Diente37.Image = (Image)Recursos.GetObject("Estado" + _Diente37);
                }
                catch { Diente37.Image = null; }


            }


        }
        #endregion

        #region Diente 38
        [Description("Valor de el diente numero 38")]
        [Localizable(true)]
        [Category("Lateral Derecha Inferior")]
        [Browsable(true)]

        public virtual Int32 DienteNumero38
        {


            get { return _Diente38; }

            set
            {

                if ((value > NivelDeImagen) || (value <= 0))
                    value = 11111;

                _Diente38 = value;

                try
                {
                    Diente38.Image = (Image)Recursos.GetObject("Estado" + _Diente38);
                }
                catch { Diente38.Image = null; }


            }


        }
        #endregion

        #endregion

        #region Dientes de la parte Lateral Izquierda Inferior

        #region Diente 41
        [Description("Valor de el diente numero 41")]
        [Localizable(true)]
        [Category("Lateral Izquierda Inferior")]
        [Browsable(true)]

        public virtual Int32 DienteNumero41
        {

            get { return _Diente41; }

            set
            {

                if ((value > NivelDeImagen) || (value <= 0))
                    value = 11111;

                _Diente41 = value;

                try
                {
                    Diente41.Image = (Image)Recursos.GetObject("Estado" + _Diente41);
                }
                catch { Diente41.Image = null; }


            }


        }
        #endregion

        #region Diente 42
        [Description("Valor de el diente numero 42")]
        [Localizable(true)]
        [Category("Lateral Izquierda Inferior")]
        [Browsable(true)]

        public virtual Int32 DienteNumero42
        {


            get { return _Diente42; }

            set
            {

                if ((value > NivelDeImagen) || (value <= 0))
                    value = 11111;

                _Diente42 = value;

                try
                {
                    Diente42.Image = (Image)Recursos.GetObject("Estado" + _Diente42);
                }
                catch { Diente42.Image = null; }


            }


        }
        #endregion

        #region Diente 43
        [Description("Valor de el diente numero 43")]
        [Localizable(true)]
        [Category("Lateral Izquierda Inferior")]
        [Browsable(true)]

        public virtual Int32 DienteNumero43
        {

            get { return _Diente43; }

            set
            {

                if ((value > NivelDeImagen) || (value <= 0))
                    value = 11111;

                _Diente43 = value;

                try
                {
                    Diente43.Image = (Image)Recursos.GetObject("Estado" + _Diente43);
                }
                catch { Diente43.Image = null; }


            }


        }
        #endregion

        #region Diente 44
        [Description("Valor de el diente numero 44")]
        [Localizable(true)]
        [Category("Lateral Izquierda Inferior")]
        [Browsable(true)]

        public virtual Int32 DienteNumero44
        {


            get { return _Diente44; }

            set
            {

                if ((value > NivelDeImagen) || (value <= 0))
                    value = 11111;

                _Diente44 = value;

                try
                {
                    Diente44.Image = (Image)Recursos.GetObject("Estado" + _Diente44);
                }
                catch { Diente44.Image = null; }


            }


        }
        #endregion

        #region Diente 45
        [Description("Valor de el diente numero 45")]
        [Localizable(true)]
        [Category("Lateral Izquierda Inferior")]
        [Browsable(true)]

        public virtual Int32 DienteNumero45
        {

            get { return _Diente45; }

            set
            {

                if ((value > NivelDeImagen) || (value <= 0))
                    value = 11111;

                _Diente45 = value;

                try
                {
                    Diente45.Image = (Image)Recursos.GetObject("Estado" + _Diente45);
                }
                catch { Diente45.Image = null; }


            }


        }
        #endregion

        #region Diente 46
        [Description("Valor de el diente numero 46")]
        [Localizable(true)]
        [Category("Lateral Izquierda Inferior")]
        [Browsable(true)]

        public virtual Int32 DienteNumero46
        {


            get { return _Diente46; }

            set
            {

                if ((value > NivelDeImagen) || (value <= 0))
                    value = 11111;

                _Diente46 = value;

                try
                {
                    Diente46.Image = (Image)Recursos.GetObject("Estado" + _Diente46);
                }
                catch { Diente46.Image = null; }


            }


        }
        #endregion

        #region Diente 47
        [Description("Valor de el diente numero 47")]
        [Localizable(true)]
        [Category("Lateral Izquierda Inferior")]
        [Browsable(true)]

        public virtual Int32 DienteNumero47
        {

            get { return _Diente47; }

            set
            {

                if ((value > NivelDeImagen) || (value <= 0))
                    value = 11111;

                _Diente47 = value;

                try
                {
                    Diente47.Image = (Image)Recursos.GetObject("Estado" + _Diente47);
                }
                catch { Diente47.Image = null; }


            }


        }
        #endregion

        #region Diente 48
        [Description("Valor de el diente numero 48")]
        [Localizable(true)]
        [Category("Lateral Izquierda Inferior")]
        [Browsable(true)]

        public virtual Int32 DienteNumero48
        {


            get { return _Diente48; }

            set
            {

                if ((value > NivelDeImagen) || (value <= 0))
                    value = 11111;

                _Diente48 = value;

                try
                {
                    Diente48.Image = (Image)Recursos.GetObject("Estado" + _Diente48);
                }
                catch { Diente48.Image = null; }


            }


        }
        #endregion

        #endregion 
  
        #region Numero Diente Seleccion 
        [Description("Obtiene el valor del diente al que se le hace click")]
        [Localizable(true)]
        [Category("Numero de Diente Clickeado")]
        [Browsable(true)]

        public virtual Int32 CodDiente
        {

            get { return _NumeroDeDienteSelecionado; }

            set
            {

                if ((value > NivelDeImagen) || (value <= 0))
                    value = 11111;

                _NumeroDeDienteSelecionado = value;

            }


        }


        #endregion

        #region Constructor
        public DientesTotales()
        {
            InitializeComponent();
        }
        #endregion 

        #region LoadFormulario
        private void DientesTotales_Load(object sender, EventArgs e)
        {
            Diente18.Image = (Image)Recursos.GetObject("Estado"+_Diente18);
            Diente17.Image = (Image)Recursos.GetObject("Estado" + _Diente17);
            Diente16.Image = (Image)Recursos.GetObject("Estado" + _Diente16);
            Diente15.Image = (Image)Recursos.GetObject("Estado" + _Diente15);
            Diente14.Image = (Image)Recursos.GetObject("Estado" + _Diente14 );
            Diente13.Image = (Image)Recursos.GetObject("Estado" + _Diente13);
            Diente12.Image = (Image)Recursos.GetObject("Estado" + _Diente12);
            Diente11.Image = (Image)Recursos.GetObject("Estado" + _Diente11);
            Diente28.Image = (Image)Recursos.GetObject("Estado" + _Diente28);
            Diente27.Image = (Image)Recursos.GetObject("Estado" + _Diente27);
            Diente26.Image = (Image)Recursos.GetObject("Estado" + _Diente26);
            Diente25.Image = (Image)Recursos.GetObject("Estado" + _Diente25);
            Diente24.Image = (Image)Recursos.GetObject("Estado" + _Diente24);
            Diente23.Image = (Image)Recursos.GetObject("Estado" + _Diente23);
            Diente22.Image = (Image)Recursos.GetObject("Estado" + _Diente22);
            Diente21.Image = (Image)Recursos.GetObject("Estado" + _Diente21);
            Diente38.Image = (Image)Recursos.GetObject("Estado" + _Diente38);
            Diente37.Image = (Image)Recursos.GetObject("Estado" + _Diente37);
            Diente36.Image = (Image)Recursos.GetObject("Estado" + _Diente36);
            Diente35.Image = (Image)Recursos.GetObject("Estado" + _Diente35);
            Diente34.Image = (Image)Recursos.GetObject("Estado" + _Diente34);
            Diente33.Image = (Image)Recursos.GetObject("Estado" + _Diente33);
            Diente32.Image = (Image)Recursos.GetObject("Estado" + _Diente32);
            Diente31.Image = (Image)Recursos.GetObject("Estado" + _Diente31);
            Diente48.Image = (Image)Recursos.GetObject("Estado" + _Diente48);
            Diente47.Image = (Image)Recursos.GetObject("Estado" + _Diente47);
            Diente46.Image = (Image)Recursos.GetObject("Estado" + _Diente46);
            Diente45.Image = (Image)Recursos.GetObject("Estado" + _Diente45);
            Diente44.Image = (Image)Recursos.GetObject("Estado" + _Diente44);
            Diente43.Image = (Image)Recursos.GetObject("Estado" + _Diente43);
            Diente42.Image = (Image)Recursos.GetObject("Estado" + _Diente42);
            Diente41.Image = (Image)Recursos.GetObject("Estado" + _Diente41);
   

        }
        #endregion   

        #region Evento de click Heredado cuya accion Retorna el Numero de Diente

        #region Partes de Dientes  Con codigo 1 

        #region Diente 11

        public event System.EventHandler DienteNumero11Click;

        private void Diente11_Click(object sender, EventArgs e)
        {
          try
            {
                CodDiente = 11; 
            }
            catch {  }
            if (DienteNumero11Click != null)
            {
                DienteNumero11Click(sender, e);
            }

        }

        #endregion 

        #region Diente 12

        public event System.EventHandler DienteNumero12Click;

        private void Diente12_Click(object sender, EventArgs e)
        {
            try
            {
                CodDiente = 12;
            }
            catch { }
            if (DienteNumero12Click != null)
            {
                DienteNumero12Click(sender, e);
            }
        }

        #endregion 

        #region Diente 13

        public event System.EventHandler DienteNumero13Click;

        private void Diente13_Click(object sender, EventArgs e)
        {
            try
            {
                CodDiente = 13;
            }
            catch { }
            if (DienteNumero13Click != null)
            {
                DienteNumero13Click(sender, e);
            }
        }


        #endregion

        #region Diente 14

        public event System.EventHandler DienteNumero14Click;

        private void Diente14_Click(object sender, EventArgs e)
        {

            try
            {
                CodDiente = 14;
            }
            catch { }
            if (DienteNumero14Click != null)
            {
                DienteNumero14Click(sender, e);
            }
        }

        #endregion 

        #region Diente 15

        public event System.EventHandler DienteNumero15Click;

        private void Diente15_Click(object sender, EventArgs e)
        {
            try
            {
                CodDiente = 15;
            }
            catch { }
            if (DienteNumero15Click != null)
            {
                DienteNumero15Click(sender, e);
            }

        }

        #endregion

        #region Diente 16

        public event System.EventHandler DienteNumero16Click;

        private void Diente16_Click(object sender, EventArgs e)
        {
            try
            {
                CodDiente = 16;
            }
            catch { }
            if (DienteNumero16Click != null)
            {
                DienteNumero16Click(sender, e);
            }
        }

        #endregion

        #region Diente 17

        public event System.EventHandler DienteNumero17Click;

        private void Diente17_Click(object sender, EventArgs e)
        {
            try
            {
                CodDiente = 17;
            }
            catch { }
            if (DienteNumero17Click != null)
            {
                DienteNumero17Click(sender, e);
            }

        }

        #endregion

        #region Diente 18

        public event System.EventHandler DienteNumero18Click;

        private void Diente18_Click(object sender, EventArgs e)
        {
            try
            {
                CodDiente = 18;
            }
            catch { }
            if (DienteNumero18Click != null)
            {
                DienteNumero18Click(sender, e);
            }
        }

        #endregion 

        #endregion 
       
        #region Partes de Dientes  Con codigo 2

        #region Diente 21

        public event System.EventHandler DienteNumero21Click;

        private void Diente21_Click_1(object sender, EventArgs e)
        {
            try
            {
                CodDiente = 21;
            }
            catch { }
            if (DienteNumero21Click != null)
            {
                DienteNumero21Click(sender, e);
            }

        }

        #endregion

        #region Diente 22

        public event System.EventHandler DienteNumero22Click;

        private void Diente22_Click(object sender, EventArgs e)
        {
            try
            {
                CodDiente = 22;
            }
            catch { }
            if (DienteNumero22Click != null)
            {
                DienteNumero22Click(sender, e);
            }
        }

        #endregion

        #region Diente 23

        public event System.EventHandler DienteNumero23Click;


        private void Diente23_Click(object sender, EventArgs e)
        {
            try
            {
                CodDiente = 23;
            }
            catch { }
            if (DienteNumero23Click != null)
            {
                DienteNumero23Click(sender, e);
            }
        }


        #endregion

        #region Diente 24

        public event System.EventHandler DienteNumero24Click;

        
        private void Diente24_Click(object sender, EventArgs e)
        {       
             try
            {
                CodDiente = 24;
            }
            catch { }
            if (DienteNumero24Click != null)
            {
                DienteNumero24Click(sender, e);
            }
        }

        #endregion

        #region Diente 25

        public event System.EventHandler DienteNumero25Click;
        
        private void Diente25_Click(object sender, EventArgs e)
        {
            try
            {
                CodDiente = 25;
            }
            catch { }
            if (DienteNumero25Click != null)
            {
                DienteNumero25Click(sender, e);
            }

        }

        #endregion

        #region Diente 26

        public event System.EventHandler DienteNumero26Click;





        private void Diente26_Click(object sender, EventArgs e)
        {
        
        
            try
            {
                CodDiente = 26;
            }
            catch { }
            if (DienteNumero26Click != null)
            {
                DienteNumero26Click(sender, e);
            }
        }

        #endregion

        #region Diente 27

        public event System.EventHandler DienteNumero27Click;

        private void Diente27_Click(object sender, EventArgs e)
        {
            try
            {
                CodDiente = 27;
            }
            catch { }
            if (DienteNumero27Click != null)
            {
                DienteNumero27Click(sender, e);
            }

        }

        #endregion

        #region Diente 28

        public event System.EventHandler DienteNumero28Click;

        private void Diente28_Click_1(object sender, EventArgs e)
        {
            try
            {
                CodDiente = 28;
            }
            catch { }
            if (DienteNumero28Click != null)
            {
                DienteNumero28Click(sender, e);
            }
        }

        #endregion





        #endregion 

        #region Partes de Dientes  Con codigo 3

        #region Diente 31

        public event System.EventHandler DienteNumero31Click;

        private void Diente31_Click(object sender, EventArgs e)
        {
            try
            {
                CodDiente = 31;
            }
            catch { }
            if (DienteNumero31Click != null)
            {
                DienteNumero31Click(sender, e);
            }

        }

        #endregion

        #region Diente 32

        public event System.EventHandler DienteNumero32Click;

        private void Diente32_Click_1(object sender, EventArgs e)
        {
            try
            {
                CodDiente = 32;
            }
            catch { }
            if (DienteNumero32Click != null)
            {
                DienteNumero32Click(sender, e);
            }
        }

        #endregion

        #region Diente 33

        public event System.EventHandler DienteNumero33Click;



        private void Diente33_Click(object sender, EventArgs e)
        {
            try
            {
                CodDiente  = 33;
            }
            catch { }
            if (DienteNumero33Click != null)
            {
                DienteNumero33Click(sender, e);
            }
        }


        #endregion

        #region Diente 34

        public event System.EventHandler DienteNumero34Click;


        

        private void Diente34_Click(object sender, EventArgs e)
        {
        
           try
            {
                CodDiente = 34;
            }
            catch { }
            if (DienteNumero34Click != null)
            {
                DienteNumero34Click(sender, e);
            }
        }

        #endregion

        #region Diente 35

        public event System.EventHandler DienteNumero35Click;

        

        private void Diente35_Click(object sender, EventArgs e)
        {
            try
            {
                CodDiente  = 35;
            }
            catch { }
            if (DienteNumero35Click != null)
            {
                DienteNumero35Click(sender, e);
            }

        }

        #endregion

        #region Diente 36

        public event System.EventHandler DienteNumero36Click;

        private void Diente36_Click(object sender, EventArgs e)
        {
            try
            {
                CodDiente = 36;
            }
            catch { }
            if (DienteNumero36Click != null)
            {
                DienteNumero36Click(sender, e);
            }
        }

        #endregion

        #region Diente 37

        public event System.EventHandler DienteNumero37Click;

        
        private void Diente37_Click(object sender, EventArgs e)
        {
        
            try
            {
                CodDiente = 37;
            }
            catch { }
            if (DienteNumero37Click != null)
            {
                DienteNumero37Click(sender, e);
            }

        }

        #endregion

        #region Diente 38

        public event System.EventHandler DienteNumero38Click;


        private void Diente38_Click(object sender, EventArgs e)
        {
            try
            {
                CodDiente = 38;
            }
            catch { }
            if (DienteNumero38Click != null)
            {
                DienteNumero38Click(sender, e);
            }
        }

        #endregion

        #endregion

        #region Partes de Dientes  Con codigo 4

        #region Diente 41

        public event System.EventHandler DienteNumero41Click;



        private void Diente41_Click(object sender, EventArgs e)
        {
            try
            {
                CodDiente = 41;
            }
            catch { }
            if (DienteNumero41Click != null)
            {
                DienteNumero41Click(sender, e);
            }

        }

        #endregion

        #region Diente 42

        public event System.EventHandler DienteNumero42Click;

        

        private void Diente42_Click(object sender, EventArgs e)
        {
        
                 try
            {
                CodDiente = 42;
            }
            catch { }
            if (DienteNumero42Click != null)
            {
                DienteNumero42Click(sender, e);
            }
        }

        #endregion

        #region Diente 43

        public event System.EventHandler DienteNumero43Click;

        private void Diente43_Click(object sender, EventArgs e)
        {
            try
            {
                CodDiente = 43;
            }
            catch { }
            if (DienteNumero43Click != null)
            {
                DienteNumero43Click(sender, e);
            }
        }


        #endregion

        #region Diente 44

        public event System.EventHandler DienteNumero44Click;



        private void Diente44_Click(object sender, EventArgs e)
        {
            try
            {
                CodDiente  = 44;
            }
            catch { }
            if (DienteNumero44Click != null)
            {
                DienteNumero44Click(sender, e);
            }
        }

        #endregion

        #region Diente 45

        public event System.EventHandler DienteNumero45Click;

        private void Diente45_Click(object sender, EventArgs e)
        {
            
            try
            {
                CodDiente   = 45;
            }
            catch { }
            if (DienteNumero45Click != null)
            {
                DienteNumero45Click(sender, e);
            }

        }

        #endregion

        #region Diente 46

        public event System.EventHandler DienteNumero46Click;

        

        private void Diente46_Click(object sender, EventArgs e)
        {
        
            try
            {
                CodDiente = 46;
            }
            catch { }
            if (DienteNumero46Click != null)
            {
                DienteNumero46Click(sender, e);
            }
        }

        #endregion

        #region Diente 47

        public event System.EventHandler DienteNumero47Click;

        

        private void Diente47_Click(object sender, EventArgs e)
        {
        
                  try
            {
                CodDiente = 47;
            }
            catch { }
            if (DienteNumero47Click != null)
            {
                DienteNumero47Click(sender, e);
            }

        }

        #endregion

        #region Diente 48

        public event System.EventHandler DienteNumero48Click;

        

        private void Diente48_Click(object sender, EventArgs e)
        {
        
            try
            {
                CodDiente = 48;
            }
            catch { }
            if (DienteNumero48Click != null)
            {
                DienteNumero48Click(sender, e);
            }
        }

        #endregion

        #endregion       


        #endregion







    }
}
