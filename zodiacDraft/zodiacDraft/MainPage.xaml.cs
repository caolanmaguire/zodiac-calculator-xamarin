using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace zodiacDraft
{
     public enum ZodiacSigns
    {
        Aries, Taurus, Gemini, Cancer, Leo, Virgo, Libra, Scorpius, Sagittarius, Capricorn, Aquarius, Pisces
    }
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }


        private async void Button1_Clicked(object sender, EventArgs e)
        {
            string action = await DisplayActionSheet("Aries Traits: Competitive, energetic, impulsive, fearless", null, "return");
        }

        private async void Button2_Clicked(object sender, EventArgs e)
        {
            string action1 = await DisplayActionSheet("Taurus Traits: Resolute, grounded, tenacious, sensual", null, "return");
        }

        private async void Button3_Clicked(object sender, EventArgs e)
        {
            string action2 = await DisplayActionSheet("Gemini Traits: Witty, curious, charming, flighty", null, "return");
        }

        private async void Button4_Clicked(object sender, EventArgs e)
        {
            string action3 = await DisplayActionSheet("Cancer Traits: Compassionate, giving, sentimental, nurturing", null, "return");
        }

        private async void Button5_Clicked(object sender, EventArgs e)
        {
            string action4 = await DisplayActionSheet("Leo Traits: Charismatic, generous, optimistic, dramatic", null, "return");
        }

        private async void Button6_Clicked(object sender, EventArgs e)
        {
            string action5 = await DisplayActionSheet("Virgo Traits: Health-conscious, analytical, service-oriented, detail-focused", null, "return");
        }

        private async void Button7_Clicked(object sender, EventArgs e)
        {
            string action6 = await DisplayActionSheet("Libra Traits: Romantic, artistic, indecisive, diplomatic", null, "return");
        }

        private async void Button8_Clicked(object sender, EventArgs e)
        {
            string action7 = await DisplayActionSheet("Scorpio Traits: Mysterious, magnetic, power-seeking, spiritual", null, "return");
        }

        private async void Button9_Clicked(object sender, EventArgs e)
        {
            string action8 = await DisplayActionSheet("Capricorn Traits: Traditional, down-to-earth, industrious, disciplined", null, "return");
        }

        private async void Button10_Clicked(object sender, EventArgs e)
        {
            string action9 = await DisplayActionSheet("Sagittarius Traits: Philosophical, free-spirited, unfiltered, wanderlusting", null, "return");
        }

        private async void Button11_Clicked(object sender, EventArgs e)
        {
            string action10 = await DisplayActionSheet("Aquarius Traits: Humanitarian, eccentric, individualistic, cool", null, "return");
        }

        private async void Button12_Clicked(object sender, EventArgs e)
        {
            string action11 = await DisplayActionSheet("Pisces Traits: Empathic, artistic, psychic, dreamy", null, "return");
        }



        private async void Button13_Clicked(object sender, EventArgs e)
        {


            if (Month.Text == "december")
            {


                if (double.Parse(Day.Text) < 22)
                {
                    await DisplayActionSheet("Your zodiac sign is: " + ZodiacSigns.Capricorn, null, "Back");
                }
                else
                {
                    await DisplayActionSheet("Your zodiac sign is: " + ZodiacSigns.Sagittarius, null, "Back");
                }
            }

            
            if (Month.Text == "january")
            {
                if (double.Parse(Day.Text) < 20)
                {
                    await DisplayActionSheet("Your zodiac sign is: " + ZodiacSigns.Capricorn, null, "Back");
                }
                else
                {
                    await DisplayActionSheet("Your zodiac sign is: ", null, "Back" + ZodiacSigns.Aquarius);
                }
            }
            if (Month.Text == "febuary")
            {
                if (double.Parse(Day.Text) < 19)
                {
                    await DisplayActionSheet("Your zodiac sign is: ", null, "Back" + ZodiacSigns.Aquarius);
                   
                }
                else
                {
                    await DisplayActionSheet("Your zodiac sign is: ", null, "Back" + ZodiacSigns.Pisces);
                }
            }
            if (Month.Text == "march")
            {
                if (double.Parse(Day.Text) < 21)
                {
                    await DisplayActionSheet("Your zodiac sign is: ", null, "Back" + ZodiacSigns.Pisces);
                }
                else
                {
                    await DisplayActionSheet("Your zodiac sign is: ", null, "Back" + ZodiacSigns.Aries);
                }
            }
            if (Month.Text == "april")
            {
                if (double.Parse(Day.Text) < 20)
                {
                    await DisplayActionSheet("Your zodiac sign is: ", null, "Back" + ZodiacSigns.Aries);
                }
                else
                {
                    await DisplayActionSheet("Your zodiac sign is: ", null, "Back" + ZodiacSigns.Taurus);
                }
            }
            if (Month.Text == "may")
            {
                if (double.Parse(Day.Text) < 21)
                {
                    await DisplayActionSheet("Your zodiac sign is: ", null, "Back" + ZodiacSigns.Taurus);
                }
                else
                {
                    await DisplayActionSheet("Your zodiac sign is: ", null, "Back" + ZodiacSigns.Gemini);
                }
            }
            if (Month.Text == "june")
            {
                if (double.Parse(Day.Text) < 21)
                {
                    await DisplayActionSheet("Your zodiac sign is: ", null, "Back" + ZodiacSigns.Gemini);
                }
                else
                {
                    await DisplayActionSheet("Your zodiac sign is: ", null, "Back" + ZodiacSigns.Cancer);
                }
            }
            if (Month.Text == "july")
            {
                if (double.Parse(Day.Text) < 22)
                {
                    await DisplayActionSheet("Your zodiac sign is: ", null, "Back" + ZodiacSigns.Cancer);
                }
                else
                {
                    await DisplayActionSheet("Your zodiac sign is: ", null, "Back" + ZodiacSigns.Leo);
                }
            }
            if (Month.Text == "august")
            {
                if (double.Parse(Day.Text) < 23)
                {
                    await DisplayActionSheet("Your zodiac sign is: ", null, "Back" + ZodiacSigns.Leo);
                }
                else
                {
                    await DisplayActionSheet("Your zodiac sign is: ", null, "Back" + ZodiacSigns.Virgo);
                }
            }
            if (Month.Text == "september")
            {
                if (double.Parse(Day.Text) < 23)
                {
                    await DisplayActionSheet("Your zodiac sign is: ", null, "Back" + ZodiacSigns.Virgo);
                }
                else
                {
                    await DisplayActionSheet("Your zodiac sign is: ", null, "Back" + ZodiacSigns.Libra);
                }
            }
            if (Month.Text == "october")
            {
                if (double.Parse(Day.Text) < 23)
                {
                    await DisplayActionSheet("Your zodiac sign is: ", null, "Back" + ZodiacSigns.Libra);
                }
                else
                {
                    await DisplayActionSheet("Your zodiac sign is: ", null, "Back" + ZodiacSigns.Scorpius);
                }
            }
            if (Month.Text == "november")
            {
                if (double.Parse(Day.Text) < 22)
                {
                    await DisplayActionSheet("Your zodiac sign is: ", null, "Back" + ZodiacSigns.Scorpius);
                }
                else
                {
                    await DisplayActionSheet("Your zodiac sign is: ", null, "Back" + ZodiacSigns.Sagittarius);
                }
            }
        }


    }

