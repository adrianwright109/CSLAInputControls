using System;
using System.ComponentModel.DataAnnotations;
using Csla;

namespace CSLAInputControls.Shared
{
    [Serializable]
    public class BusinessModel : BusinessBase<BusinessModel>
    {
        private const string DefaultTelerikTextBoxFriendlyName = "Default";
        public static readonly PropertyInfo<string> DefaultTelerikTextBoxProperty = RegisterProperty<string>(propertyName: nameof(DefaultTelerikTextBox), friendlyName: DefaultTelerikTextBoxFriendlyName);
        [Required]
        [Display(Name = DefaultTelerikTextBoxFriendlyName)]
        public string DefaultTelerikTextBox
        {
            get => GetProperty(DefaultTelerikTextBoxProperty);
            set => SetProperty(DefaultTelerikTextBoxProperty, value);
        }

        private const string StandardTelerikTextBoxFriendlyName = "Standard";
        public static readonly PropertyInfo<string> StandardTelerikTextBoxProperty = RegisterProperty<string>(propertyName: nameof(StandardTelerikTextBox), friendlyName: StandardTelerikTextBoxFriendlyName);
        [Required]
        [Display(Name = StandardTelerikTextBoxFriendlyName)]
        public string StandardTelerikTextBox
        {
            get => GetProperty(StandardTelerikTextBoxProperty);
            set => SetProperty(StandardTelerikTextBoxProperty, value);
        }

        private const string CustomTelerikTextBoxFriendlyName = "Custom";
        public static readonly PropertyInfo<string> CustomTelerikTextBoxProperty = RegisterProperty<string>(propertyName: nameof(CustomTelerikTextBox), friendlyName: CustomTelerikTextBoxFriendlyName);
        [Required]
        [Display(Name = CustomTelerikTextBoxFriendlyName)]
        public string CustomTelerikTextBox
        {
            get => GetProperty(CustomTelerikTextBoxProperty);
            set => SetProperty(CustomTelerikTextBoxProperty, value);
        }

        private const string DefaultTelerikNumericTextBoxFriendlyName = "Default";
        public static readonly PropertyInfo<decimal?> DefaultTelerikNumericTextBoxProperty = RegisterProperty<decimal?>(propertyName: nameof(DefaultTelerikNumericTextBox), friendlyName: DefaultTelerikNumericTextBoxFriendlyName);
        [Required]
        [Display(Name = DefaultTelerikNumericTextBoxFriendlyName)]
        public decimal? DefaultTelerikNumericTextBox
        {
            get => GetProperty(DefaultTelerikNumericTextBoxProperty);
            set => SetProperty(DefaultTelerikNumericTextBoxProperty, value);
        }

        private const string StandardTelerikNumericTextBoxFriendlyName = "Standard";
        public static readonly PropertyInfo<decimal?> StandardTelerikNumericTextBoxProperty = RegisterProperty<decimal?>(propertyName: nameof(StandardTelerikNumericTextBox), friendlyName: StandardTelerikNumericTextBoxFriendlyName);
        [Required]
        [Display(Name = StandardTelerikNumericTextBoxFriendlyName)]
        public decimal? StandardTelerikNumericTextBox
        {
            get => GetProperty(StandardTelerikNumericTextBoxProperty);
            set => SetProperty(StandardTelerikNumericTextBoxProperty, value);
        }

        private const string CustomTelerikNumericTextBoxFriendlyName = "Custom";
        public static readonly PropertyInfo<decimal?> CustomTelerikNumericTextBoxProperty = RegisterProperty<decimal?>(propertyName: nameof(CustomTelerikNumericTextBox), friendlyName: CustomTelerikNumericTextBoxFriendlyName);
        [Required]
        [Display(Name = CustomTelerikNumericTextBoxFriendlyName)]
        public decimal? CustomTelerikNumericTextBox
        {
            get => GetProperty(CustomTelerikNumericTextBoxProperty);
            set => SetProperty(CustomTelerikNumericTextBoxProperty, value);
        }

        [Create]
        private void Create()
        {
            using (BypassPropertyChecks)
            {
                DefaultTelerikTextBox = "Default";
                StandardTelerikTextBox = "Standard";
                CustomTelerikTextBox = "Custom";

                DefaultTelerikNumericTextBox = 5.00m;
                StandardTelerikNumericTextBox = 10.00m;
                CustomTelerikNumericTextBox = 15.00m;
            }
        }
    }
}
