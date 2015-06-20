using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace OdontogramaLib
{
    public partial class UnidadDental : UserControl
    {
        System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(ImagenUnidadDental));

        #region VARIABLES GLOBALES
        private Int32 _nivelDeImagen = 3;
        //datos de la unidad dental
        private Int32 _estadoLunaSuperior1=1;
        private Int32 _estadoLunaSuperior2 = 1;
        private Int32 _estadoLunaInferior1 = 1;
        private Int32 _estadoLunaInferior2 = 1;
        private Int32 _estadoLunaIzquierda = 1;
        private Int32 _estadoLunaDerecha = 1;
        private Int32 _estadoLunaCentral = 1;
       
        #endregion

        #region PROPIEDADES DEL CONTROL

        [Description("Establece el nivel de imagenes que se va a utilizar")]
        [Localizable(true)]
        [Category("Configuracion")]
        [Browsable(true)]
        public virtual Int32 NivelDeImagen
        {
            get { return _nivelDeImagen; }
            set {
                if (value <= 0) value = 1;//si se pretende poner 0 como nivel de cambio
                if (value != _nivelDeImagen)//si el valor actual de alguno de los estado revasa el nivel permitido
                {
                    
                    if (_estadoLunaCentral > value) _estadoLunaCentral = 1;
                    if (_estadoLunaSuperior1 > value) _estadoLunaSuperior1 = 1;
                    if (_estadoLunaSuperior2 > value) _estadoLunaSuperior2 = 1;
                    if (_estadoLunaInferior1 > value) _estadoLunaInferior1 = 1;
                    if (_estadoLunaInferior2 > value) _estadoLunaInferior2 = 1;
                    if (_estadoLunaIzquierda > value) _estadoLunaIzquierda = 1;
                    if (_estadoLunaDerecha > value) _estadoLunaDerecha = 1;
                    
                }
                _nivelDeImagen = value; 
                
            }
        }

        [Description("Estado de la luna superior 1")]
        [Localizable(true)]
        [Category("Configuracion")]
        [Browsable(true)]
        public virtual Int32 EstadoLunaSuperior1
        {
            get { return _estadoLunaSuperior1; }
            set
            {
                if ((value > NivelDeImagen) || (value <= 0))//Si se pretende poner muy altos o muy bajos
                    value = 1;

                _estadoLunaSuperior1 = value;
                
                try
                {
                    LunaSuperior1.Image = (Image)resources.GetObject("Superior1_nivel" + _estadoLunaSuperior1);
                }
                catch { LunaSuperior1.Image = null; }
            }
        }

        [Description("Estado de la luna superior 2")]
        [Localizable(true)]
        [Category("Configuracion")]
        [Browsable(true)]
        public virtual Int32 EstadoLunaSuperior2
        {
            get { return _estadoLunaSuperior2; }
            set
            {
                if ((value > NivelDeImagen) || (value <= 0))//Si se pretende poner muy altos o muy bajos
                    value = 1;
                _estadoLunaSuperior2 = value;
                try//Se actualiza la imagen a mostrar con el nuevo estado
                {
                    LunaSuperior2.Image = (Image)resources.GetObject("Superior2_nivel" + _estadoLunaSuperior2);
                }
                catch { LunaSuperior2.Image = null; }
            }
        }

        //[Description("Estado de la luna inferior 1")]
        //[Localizable(true)]
        //[Category("Configuracion")]
        //[Browsable(true)]
        //public virtual Int32 EstadoLunaInferior1
        //{
        //    get { return _estadoLunaInferior1; }
        //    set
        //    {
        //        if ((value > NivelDeImagen) || (value <= 0))//Si se pretende poner muy altos o muy bajos
        //            value = 1;
        //        _estadoLunaInferior1 = value;
        //        try//Se actualiza la imagen a mostrar con el nuevo estado
        //        {
        //            LunaInferior1.Image = (Image)resources.GetObject("Inferior1_nivel" + _estadoLunaInferior1);
        //        }
        //        catch { LunaInferior1.Image = null; }
        //    }
        //}

        [Description("Estado de la luna inferior 2")]
        [Localizable(true)]
        [Category("Configuracion")]
        [Browsable(true)]
        public virtual Int32 EstadoLunaInferior2
        {
            get { return _estadoLunaInferior2; }
            set
            {
                if ((value > NivelDeImagen) || (value <= 0))//Si se pretende poner muy altos o muy bajos
                    value = 1;
                _estadoLunaInferior2 = value;
                try//Se actualiza la imagen a mostrar con el nuevo estado
                {
                    LunaInferior2.Image = (Image)resources.GetObject("Inferior2_nivel" + _estadoLunaInferior2);
                }
                catch { LunaInferior2.Image = null; }
            }
        }

        [Description("Estado de la luna izquierda")]
        [Localizable(true)]
        [Category("Configuracion")]
        [Browsable(true)]
        public virtual Int32 EstadoLunaIzquierda
        {
            get { return _estadoLunaIzquierda; }
            set
            {
                if ((value > NivelDeImagen) || (value <= 0))//Si se pretende poner muy altos o muy bajos
                    value = 1;
                _estadoLunaIzquierda = value;
                try//Se actualiza la imagen a mostrar con el nuevo estado
                {
                    LunaIzquierda.Image = (Image)resources.GetObject("LateralIzquierdo_nivel" + _estadoLunaIzquierda);
                }
                catch { LunaIzquierda.Image = null; }
            }
        }

        [Description("Estado de la luna derecha")]
        [Localizable(true)]
        [Category("Configuracion")]
        [Browsable(true)]
        public virtual Int32 EstadoLunaDerecha
        {
            get { return _estadoLunaDerecha; }
            set
            {
                if ((value > NivelDeImagen) || (value <= 0))//Si se pretende poner muy altos o muy bajos
                    value = 1;
                _estadoLunaDerecha = value;
                try//Se actualiza la imagen a mostrar con el nuevo estado
                {
                    LunaDerecha.Image = (Image)resources.GetObject("LateralDerecho_nivel" + _estadoLunaDerecha);
                }
                catch { LunaDerecha.Image = null; }
            }
        }

        [Description("Estado de la luna derecha")]
        [Localizable(true)]
        [Category("Configuracion")]
        [Browsable(true)]
        public virtual Int32 EstadoLunaCentral
        {
            get { return _estadoLunaCentral; }
            set
            {
                if ((value > NivelDeImagen) || (value <= 0))//Si se pretende poner muy altos o muy bajos
                    value = 1;
                _estadoLunaCentral = value;
                try//Se actualiza la imagen a mostrar con el nuevo estado
                {
                    LunaCentral.Image = (Image)resources.GetObject("Central_nivel" + _estadoLunaCentral);
                }
                catch { LunaCentral.Image = null; }
            }
        }
        #endregion


        #region COSTRUCTOR

        public UnidadDental()
        {
            InitializeComponent();
        }
        #endregion



        /// <summary>
        /// Se cargan la imagen con estado 1 para todos los controles
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void UnidadDental_Load(object sender, EventArgs e)
        {
            try
            {
                LunaSuperior1.Image = (Image)resources.GetObject("Superior1_nivel" + _estadoLunaSuperior1);
                LunaSuperior2.Image = (Image)resources.GetObject("Superior2_nivel" + _estadoLunaSuperior2);
                //LunaInferior1.Image = (Image)resources.GetObject("Inferior1_nivel" + _estadoLunaInferior1);
                LunaInferior2.Image = (Image)resources.GetObject("Inferior2_nivel" + _estadoLunaInferior2);
                LunaDerecha.Image = (Image)resources.GetObject("LateralDerecho_nivel" + _estadoLunaDerecha);
                LunaIzquierda.Image = (Image)resources.GetObject("LateralIzquierdo_nivel" + _estadoLunaIzquierda);
                LunaCentral.Image = (Image)resources.GetObject("Central_nivel" + _estadoLunaCentral);

            }
            catch { }
        }

        //Evento click heredado  para tener disponible en el Form
        public event System.EventHandler LunaSuperior1Click;

        /// <summary>
        /// Para cambiar los estados de las lunas
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void LunaSuperior1_Click(object sender, EventArgs e)
        {
            try
            {
                if (EstadoLunaSuperior1 < NivelDeImagen)
                    EstadoLunaSuperior1++;
                else
                    EstadoLunaSuperior1 = 1;
            }
            catch { LunaSuperior1.Image = null; }
            
            //Heredamos el evento click para tener disponible en el Form
            if (LunaSuperior1Click != null)
            {
                LunaSuperior1Click(sender, e);
            }
        }

        //Evento click heredado  para tener disponible en el Form
        public event System.EventHandler LunaSuperior2Click;
        /// <summary>
        /// Para cambiar los estados de las lunas
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void LunaSuperior2_Click(object sender, EventArgs e)
        {
            try
            {
                if (EstadoLunaSuperior2 < NivelDeImagen)
                    EstadoLunaSuperior2++;
                else
                    EstadoLunaSuperior2 = 1;
            }
            catch { LunaSuperior2.Image = null; }
            //Heredamos el evento click para tener disponible en el Form
            if (LunaSuperior2Click != null)
            {
                LunaSuperior2Click(sender, e);
            }
        }

        //Evento click heredado  para tener disponible en el Form
        public event System.EventHandler LunaIzquierdaClick;
        /// <summary>
        /// Para cambiar los estados de las lunas
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void LunaIzquierda_Click(object sender, EventArgs e)
        {
            try
            {
                if (EstadoLunaIzquierda < NivelDeImagen)
                    EstadoLunaIzquierda++;
                else
                    EstadoLunaIzquierda = 1;
            }
            catch { LunaIzquierda.Image = null; }
            if (LunaIzquierdaClick != null)
            {
                LunaIzquierdaClick(sender, e);
            }
        }

        //Evento click heredado  para tener disponible en el Form
        public event System.EventHandler LunaDerechaClick;
        /// <summary>
        /// Para cambiar los estados de las lunas
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void LunaDerecha_Click(object sender, EventArgs e)
        {
            try
            {
                if (EstadoLunaDerecha < NivelDeImagen)
                    EstadoLunaDerecha++;
                else
                    EstadoLunaDerecha = 1;
                //LunaDerecha.Image = (Image)resources.GetObject("LateralDerecho_nivel" + EstadoLunaDerecha);
            }
            catch { LunaDerecha.Image = null; }
            if (LunaDerechaClick != null)
            {
                LunaDerechaClick(sender, e);
            }
        }

        //Evento click heredado  para tener disponible en el Form
        public event System.EventHandler LunaInferior2Click;
        /// <summary>
        /// Para cambiar los estados de las lunas
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void LunaInferior2_Click(object sender, EventArgs e)
        {
            try
            {
                if (EstadoLunaInferior2 < NivelDeImagen)
                    EstadoLunaInferior2++;
                else
                    EstadoLunaInferior2 = 1;
            }
            catch { LunaInferior2.Image = null; }
            //Heredamos el evento click para tener disponible en el Form
            if (LunaInferior2Click != null)
            {
                LunaInferior2Click(sender, e);
            }
        }

        //Evento click heredado  para tener disponible en el Form
        public event System.EventHandler LunaInferior1Click;
        /// <summary>
        /// Para cambiar los estados de las lunas
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        //private void LunaInferior1_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (EstadoLunaInferior1 < NivelDeImagen)
        //            EstadoLunaInferior1++;
        //        else
        //            EstadoLunaInferior1 = 1;
        //    }
        //    catch { LunaInferior1.Image = null; }
        //    //Heredamos el evento click para tener disponible en el Form
        //    if (LunaInferior1Click != null)
        //    {
        //        LunaInferior1Click(sender, e);
        //    }
        //}

        //Evento click heredado  para tener disponible en el Form
        public event System.EventHandler LunaCentralClick;
        /// <summary>
        /// Para cambiar los estados de las lunas
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void LunaCentral_Click(object sender, EventArgs e)
        {
            try
            {
                if (EstadoLunaCentral < NivelDeImagen)
                    EstadoLunaCentral++;
                else
                    EstadoLunaCentral = 1;
                //LunaCentral.Image = (Image)resources.GetObject("Central_nivel" + _estadoLunaCentral);
            }
            catch { LunaCentral.Image = null; }
            if (LunaCentralClick != null)
            {
                LunaCentralClick(sender, e);
            }
        }
    }
}
