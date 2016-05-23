using System;
using Xamarin.Forms;

namespace BetterForms.Effects
{
    public class ReturnKeyEffect:RoutingEffect
    {

        public string ReturnText{ get; set; }

        public ReturnKeyEffect()
            : base("Brax.ReturnKeyEffect")
        {
        }
    }
}

