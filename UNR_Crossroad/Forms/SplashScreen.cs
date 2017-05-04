using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using UNR_Crossroad.Core;
using Timer = System.Windows.Forms.Timer;

namespace UNR_Crossroad.Forms
{
    public partial class SplashScreen : Form
    {
        private readonly Bitmap _loadImg = new Bitmap("img\\Load.gif");
        private bool _isAnim;

        public SplashScreen()
        {
            InitializeComponent();
            Timer openTimer = new Timer { Interval = 1 };
            Timer waiTimer = new Timer { Interval = 500 };
            Timer closeTimer = new Timer { Interval = 1 };
            Opacity = 0;

            // Плавное появление сплэшскрина
            openTimer.Tick += (sender, e) =>
            {
                if (Math.Abs((Opacity += 0.03) - 1) <= 0.01)
                {
                    Opacity = 1;
                    openTimer.Stop();
                    new Thread(() => CarSprite.LoadCarSpriteLib(lbLoad)).Start();
                }
            };
            openTimer.Start();

            // Ожидание 6 сек.
            waiTimer.Tick += (sender, e) =>
            {
                if (CarSprite.IsDone)
                {
                    closeTimer.Start();
                }
            }; 
            waiTimer.Start();

            // Плавоне исчезновение
            closeTimer.Tick += (sender, e) =>
            {
                if (Math.Abs((Opacity -= 0.07) + 1) < 1)
                {
                    closeTimer.Stop();
                    Close();
                }
            };

            AnimateImage();
        }


        // Метод начинает анимацию
        private void AnimateImage()
        {
            if (!_isAnim)
            {
                ImageAnimator.Animate(_loadImg, OnFrameChanged);
                _isAnim = true;
            }
        }

        private void OnFrameChanged(object o, EventArgs e)
        {
            // Перерисовка элемента управления
            Invalidate();
        }

        // Вызывает событие, которое происходит при перерисовке элемента управления
        protected override void OnPaint(PaintEventArgs e)
        {
            //Рисуем заного
            AnimateImage();

            //Загружаем следующий фрейм для рендеринга
            ImageAnimator.UpdateFrames();

            //Рисуем следующий фрейм
            e.Graphics.DrawImage(_loadImg, new Point(450, 500));
        }
    }
}
