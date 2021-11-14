using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mids_Reborn.UIv2.v2Controls
{
    public partial class PowerListCombo : UserControl
    {
        

        public PowerListCombo()
        {
            InitializeComponent();
        }

        #region TypeConverters

        [TypeConverter(typeof(ExpandableObjectConverter))]
        public class ComboProperties
        {
            public enum ComboBoxType
            {
                Archetype,
                Origin,
                Primary,
                Secondary,
                Pool,
                Ancillary
            }

            [Description("Data type to display")]
            [Category("Appearance")]
            [Browsable(true)]
            [EditorBrowsable(EditorBrowsableState.Always)]
            [Bindable(true)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
            public ComboBoxType ComboType { get; set; }

            [Description("Highlight color for selected item")]
            [Category("Appearance")]
            [Browsable(true)]
            [EditorBrowsable(EditorBrowsableState.Always)]
            [Bindable(true)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
            [DefaultValue(typeof(Color), "Dodger Blue")]
            public Color HighlightColor { get; set; }
        }

        #endregion
    }
}
