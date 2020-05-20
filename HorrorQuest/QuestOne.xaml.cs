using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HorrorQuest
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuestOne : ContentPage
    {
       
        string[] MaintextRut1 = { "Просто будь осторожнее…",
            "- Да так, разные странности происходят в этом парке по ночам, будь на чеку. Если что – зови на подмогу.\n- Ахах, Эш… это тебе старина Джо в уши залил? Он же маразматичный старый пень с кучей тараканов в голове.\n- Ну, я просто предупредил, мало ли. В общем если что, зови на помощь.\nВы приступил к дежурству. Сначала всё было спокойно. Беспорядки начались, когда парк накрыло густым туманом.\nВдруг вы услышали женский крик!",
            "Вы заметили, что к вам начала приближаться фигура человека",
            "Внезапно, она начала крушить и бросать скамейки в разные стороны!\n Да что происходит?! Успокойтесь, не надо ломать собственность парка! \nВ темноте вам удалось разглядеть необъяснимое… у женщины отсутствовали ноги и она парила в воздухе.",
            "Неожиданно старуха набросилась на вас и стала яростно избивать.",
            "Убегая от проклятой безногой старухи, вы в спешке набираете номер Эша… Гудки… \n- Ммм… Билл? Что случилось? 2 часа ночи…\n- Эш, тут такое, возможно я скоро умру. Пожалуйста приезжай скорее!! ШШш, ргааах, пшш, бдумм.\n- Билл? Ты меня слышишь? Оборвалось. Что-то недоброе видно произошло, надо бежать. Благо парк недалеко от меня. \nВы добежали до входа парка и увидели приближающегося Эша.\n- Билл! Что произошло?\n- Не сейчас, отсюда надо сматываться и поскорее. Утром всё расскажу."};
        string[] MaintextRut2 = { "- Просто будь осторожнее…",
            "Вы приступил к дежурству. Сначала всё было спокойно. Беспорядки начались, когда парк накрыло густым туманом.\nВдруг вы услышали женский крик!",
            "Вы пошли на звуки крика. Перед вами стоит пожилая женщина в белом платье.",
            "Внезапно, она начала крушить и бросать скамейки в разные стороны! \nОтставить разрушения! Что произошло? \nВ темноте вам удалось разглядеть необъяснимое… у женщины отсутствовали ноги и она парила в воздухе.",
            "Неожиданно старуха набросилась на вас и стала яростно избивать.",
            "Вам удалось отбиться, вы весь покалеченный побежали к Эшу, так как он живёт недалеко о парка. Наутро вы всё ему рассказали…"};    
        string[] ButtonTextRut1 = { "А чего мне вдруг осторожничать", "Оставаться на месте", "Стой! Вы в порядке? Это вы кричали?",
        "Не может быть… Надо вызвать Эша…","Пытаться позвонить Эш"};
        string[] ButtonTextRut2 = { "Учту", "Узнать что произошло", "Гражданка, что у вас случилось?", "Твою ж налево! Кто вы такая! Изыди!", "Пытаться отбиться и убежать" };
        string[] endText = { "   Вскоре после этого случая оба охранника заболел таинственной болезнью и умерли. Городские власти запретили рассказывать об этой истории в СМИ, но слух всё равно разлетелся по городу, больше никто не хотел дежуритьне хотел дежурить по ночам.\nМестные прозвали призрак фантомом парка." };
        int b_count = 0;
        public QuestOne()
        {
            InitializeComponent();
            Rut1.Clicked += b1_v1;
            Rut2.Clicked += b2_v2;
        }

        public void b1_v1(object sender, EventArgs e)
        {
            if (b_count == 0)
            {
                TestQ.Text = MaintextRut1[b_count];
                Rut1.Text = ButtonTextRut1[b_count];
                Rut2.Text = ButtonTextRut2[b_count];
                b_count += 1;
            }
            else if (b_count == 1)
            {
                TestQ.Text = MaintextRut1[b_count];
                Rut1.Text = ButtonTextRut1[b_count];
                Rut2.Text = ButtonTextRut2[b_count];
                b_count += 1;
            }
            else if (b_count == 2)
            {
                TestQ.Text = MaintextRut1[b_count];
                Rut1.Text = ButtonTextRut1[b_count];
                Rut2.Text = ButtonTextRut2[b_count];
                b_count += 1;
            }
            else if (b_count == 3)
            {
                TestQ.Text = MaintextRut1[b_count];
                Rut1.Text = ButtonTextRut1[b_count];
                Rut2.Text = ButtonTextRut2[b_count];
                b_count += 1;
            }
            else if (b_count == 4)
            {
                TestQ.Text = MaintextRut1[b_count];
                Rut1.Text = ButtonTextRut1[b_count];
                Rut2.Text = ButtonTextRut2[b_count];
                b_count += 1;
            }
            else if(b_count == 5)
            {
                TestQ.Text = MaintextRut1[b_count];
                Rut1.Text = "Конец";
                Rut2.Text = "";
                b_count += 1;
            }
            else if (b_count == 6)
            {
                TestQ.Text = endText[0];
                Rut1.Text = "Перепеиграть";
                Rut2.Text = "Выбор квеста";
                b_count += 1;
            }
            else
            {
                Navigation.PushModalAsync(new StartQuest());
            }

        }
        public void b2_v2(object sender, EventArgs e)
        {
            if (b_count == 0)
            {
                TestQ.Text = MaintextRut2[b_count];
                Rut1.Text = ButtonTextRut1[b_count];
                Rut2.Text = ButtonTextRut2[b_count];
                b_count += 1;
            }
            else if (b_count == 1)
            {
                TestQ.Text = MaintextRut2[b_count];
                Rut1.Text = ButtonTextRut1[b_count];
                Rut2.Text = ButtonTextRut2[b_count];
                b_count += 1;
            }
            else if (b_count == 2)
            {
                TestQ.Text = MaintextRut2[b_count];
                Rut1.Text = ButtonTextRut1[b_count];
                Rut2.Text = ButtonTextRut2[b_count];
                b_count += 1;
            }
            else if (b_count == 3)
            {
                TestQ.Text = MaintextRut2[b_count];
                Rut1.Text = ButtonTextRut1[b_count];
                Rut2.Text = ButtonTextRut2[b_count];
                b_count += 1;
            }
            else if (b_count == 4)
            {
                TestQ.Text = MaintextRut1[b_count];
                Rut1.Text = ButtonTextRut1[b_count];
                Rut2.Text = ButtonTextRut2[b_count];
                b_count += 1;
            }
            else if(b_count == 5)
            {
                TestQ.Text = MaintextRut1[b_count];
                Rut1.Text = "Конец";
                Rut2.Text = "";
                b_count += 1;
            }
            else if (b_count == 6)
            {
                TestQ.Text = endText[0];
                Rut1.Text = "Перепеиграть";
                Rut2.Text = "Выбор квеста";
                b_count += 1;
            }
            else
            {
                Navigation.PushModalAsync(new MainPage());
            }
        }
    }
}