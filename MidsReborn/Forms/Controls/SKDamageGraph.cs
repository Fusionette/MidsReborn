using System;
using System.Drawing;
using System.Windows.Forms;
using mrbBase;
using SkiaSharp;
using SkiaSharp.Views.Desktop;

namespace Mids_Reborn.Forms.Controls
{
    public partial class SKDamageGraph : UserControl
    {
        private readonly Enums.eDDText _TextStyle;
        private float _BaseVal;
        private float _EnhancedVal;
        private float _HighestBase;
        private float _HighestEnhanced;
        private float _MaxEnhanced;
        private Enums.eDDAlign _TextAlign;
        private SKColor _FadeBackEnd;
        private SKColor _FadeBackStart;
        private SKColor _FadeBaseEnd;
        private SKColor _FadeBaseStart;
        private SKColor _FadeEnhEnd;
        private SKColor _FadeEnhStart;
        private Enums.eDDGraph _Graph;
        private SKSize _Padding;
        private string _String;
        private Enums.eDDStyle _GraphStyle;
        private SKColor _TextColor;
        private bool _DrawLock = false;

        public SKDamageGraph()
        {
            _GraphStyle = Enums.eDDStyle.TextUnderGraph;
            _TextStyle = Enums.eDDText.ActualValues;
            _Graph = Enums.eDDGraph.Both; 
            _FadeBackStart = SKColors.Lime;
            _FadeBackEnd = SKColors.Yellow;
            _FadeBaseStart = SKColors.Blue;
            _FadeBaseEnd = SKColors.LightBlue;
            _FadeEnhStart = SKColors.Blue;
            _FadeEnhEnd = SKColors.Red;
            _TextColor = SKColors.WhiteSmoke;
            _Padding = new SKSize(3, 6);
            _TextAlign = Enums.eDDAlign.Center;
            _BaseVal = 100f;
            _EnhancedVal = 196f;
            _MaxEnhanced = 207f;
            _HighestBase = 200f;
            _HighestEnhanced = 414f;
            _String = "196 (100)";

            Load += SKDamageGraph_Load;
            Resize += SKDamageGraph_Resize;
            skglControl1.PaintSurface += skglControl1_PaintSurface;

            InitializeComponent();
        }

        private Color ToColor(SKColor color)
        {
            return Color.FromArgb(_FadeBackStart.Red, _FadeBackStart.Green, _FadeBackStart.Blue);
        }

        private SKColor TOSKColor(Color color)
        {
            return new SKColor(color.R, color.G, color.B);
        }

        public int PaddingH
        {
            get => (int) _Padding.Width;
            set
            {
                if (!(value >= 0 & value * 2 < Width - 5))
                {
                    return;
                }

                _Padding = new SKSize(value, _Padding.Height);
                
                Draw();
            }
        }

        public int PaddingV
        {
            get => (int) _Padding.Height;
            set
            {
                if (!(value >= 0 & value * 2 < Height - 5))
                {
                    return;
                }

                _Padding = new SKSize(_Padding.Width, value);

                Draw();
            }
        }

        public Color ColorBackStart
        {
            get => ToColor(_FadeBackStart);
            set
            {
                _FadeBackStart = TOSKColor(value);

                Draw();
            }
        }

        public Color ColorBackEnd
        {
            get => ToColor(_FadeBackEnd);
            set
            {
                _FadeBackEnd = TOSKColor(value);

                Draw();
            }
        }

        public Color ColorBaseStart
        {
            get => ToColor(_FadeBaseStart);
            set
            {
                _FadeBaseStart = TOSKColor(value);

                Draw();
            }
        }

        public Color ColorBaseEnd
        {
            get => ToColor(_FadeBaseEnd);
            set
            {
                _FadeBaseEnd = TOSKColor(value);

                Draw();
            }
        }

        public Color ColorEnhStart
        {
            get => ToColor(_FadeEnhStart);
            set
            {
                _FadeEnhStart = TOSKColor(value);

                Draw();
            }
        }

        public Color ColorEnhEnd
        {
            get => ToColor(_FadeEnhEnd);
            set
            {
                _FadeEnhEnd = TOSKColor(value);

                Draw();
            }
        }

        public Color TextColor
        {
            get => ToColor(_TextColor);
            set
            {
                _TextColor = TOSKColor(value);

                Draw();
            }
        }

        // /////////////////////////////////////////

        public SKColor SKColorBackStart
        {
            get => _FadeBackStart;
            set
            {
                _FadeBackStart = value;

                Draw();
            }
        }

        public SKColor SKColorBackEnd
        {
            get => _FadeBackEnd;
            set
            {
                _FadeBackEnd = value;

                Draw();
            }
        }

        public SKColor SKColorBaseStart
        {
            get => _FadeBaseStart;
            set
            {
                _FadeBaseStart = value;

                Draw();
            }
        }

        public SKColor SKColorBaseEnd
        {
            get => _FadeBaseEnd;
            set
            {
                _FadeBaseEnd = value;

                Draw();
            }
        }

        public SKColor SKColorEnhStart
        {
            get => _FadeEnhStart;
            set
            {
                _FadeEnhStart = value;

                Draw();
            }
        }

        public SKColor SKColorEnhEnd
        {
            get => _FadeEnhEnd;
            set
            {
                _FadeEnhEnd = value;

                Draw();
            }
        }

        public SKColor SKTextColor
        {
            get => _TextColor;
            set
            {
                _TextColor = value;

                Draw();
            }
        }

        // /////////////////////////////////////////

        public Enums.eDDAlign TextAlign
        {
            get => _TextAlign;
            set
            {
                _TextAlign = value;

                Draw();
            }
        }

        public Enums.eDDStyle Style
        {
            get => _GraphStyle;
            set
            {
                _GraphStyle = value;

                Draw();
            }
        }

        public Enums.eDDGraph GraphType
        {
            get => _Graph;
            set
            {
                _Graph = value;

                Draw();
            }
        }

        public float nBaseVal
        {
            get => _BaseVal;
            set
            {
                _BaseVal = value;

                Draw();
            }
        }

        public float nEnhVal
        {
            get => _EnhancedVal;
            set
            {
                _EnhancedVal = value;

                Draw();
            }
        }

        public float nMaxEnhVal
        {
            get => _MaxEnhanced;
            set
            {
                _MaxEnhanced = value;

                Draw();
            }
        }

        public float nHighBase
        {
            get => _HighestBase;
            set
            {
                _HighestBase = value;

                Draw();
            }
        }

        public float nHighEnh
        {
            get => _HighestEnhanced;
            set
            {
                _HighestEnhanced = value;

                Draw();
            }
        }

        public override string Text
        {
            get => _String;
            set
            {
                _String = value;

                Draw();
            }
        }

        // /////////////////////////////////////////

        public void LockDraw()
        {
            _DrawLock = true;
        }

        public void UnlockDraw()
        {
            _DrawLock = false;
        }

        public void FullUpdate()
        {
            Draw();
        }

        private void SKDamageGraph_Load(object sender, EventArgs e)
        {
            Draw();
        }

        private void SKDamageGraph_Resize(object sender, EventArgs e)
        {
            FullUpdate();
        }

        private void skglControl1_PaintSurface(object sender, SKPaintGLSurfaceEventArgs e)
        {

        }

        // /////////////////////////////////////////

        public void Draw()
        {
            skglControl1.Invalidate();
        }
    }
}