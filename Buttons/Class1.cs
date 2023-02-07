using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Buttons
{
    public interface butt
    {
        string Taxte();
        void On_Click();
        void Mous_enter();
        void Mous_leev();
        void Mous_exist();
    }
    public class Button : butt
    {
        public void Mous_enter()
        {
        }

        public void Mous_exist()
        {
        }

        public void Mous_leev()
        {
        }

        public Button(string Text)
        {
            Taxt = Text;
        }
        public string Taxt ;
        public string Taxte()
        {
            return Taxt;
        }
        public void On_Click()
        {
        }
    }
     public class CheckButton : butt
    {
        public bool Clicked;
        public void Mous_enter()
        {
        }

        public void Mous_exist()
        {
        }

        public CheckButton(string Text)
        {
            Taxt = Text;
        }
        public string Taxt;
        public string Taxte()
        {
            return Taxt;
        }
        public void Mous_leev()
        {
        }


        public void On_Click()
        {
            Clicked = !Clicked;
        }
    }
    public class RadioButton : butt
    {
        public bool Clicked;
        public int ind;
        public List<RadioButton> RadioButtons;
        public void Mous_enter()
        {
        }

        public void Mous_exist()
        {
        }

        public void Mous_leev()
        {
        }

        public RadioButton(string Text,int index, List<RadioButton> radioButtons)
        {
            Taxt = Text;
            ind = index;
            radioButtons.Add(this);
            RadioButtons = radioButtons;
        }
        public string Taxt;
        public string Taxte()
        {
            return Taxt;
        }

        public void On_Click()
        {
            for(int i=0; i< RadioButtons.Count; i++) {
                if (RadioButtons[i] == this)
                {
                    RadioButtons[i].Clicked = true;
                }
                else
                {
                    if(RadioButtons[i].ind == ind)
                    RadioButtons[i].Clicked = false;
                }
            }

        }
    }
    public interface quizz
    {
        string Qwest();
        butt button1();
        butt button2();
    }
    public class ez : quizz
    {
        public ez() { }
        public string Qwest() { return "u?"; }
        public butt button1() => new Button("Da");
        public butt button2() => new Button("Nit");
    }
    public class midl : quizz
    {
        public midl() { }
        public string Qwest() { return "guy?"; }
        public butt button1() => new CheckButton("Avzhezh");
        public butt button2() => new CheckButton("Zwychajno");
    }
    public class Asian : quizz
    {
        public List<RadioButton> RadioButtons = new List<RadioButton>();
        public int ind;
        public Asian(int index) { ind = index; }
        public string Qwest() { return "Heterosexual?"; }
        public butt button1() => new RadioButton("Avzhezh", ind, RadioButtons);
        public butt button2() => new RadioButton("Zwychajno", ind, RadioButtons);
        
    }
}
