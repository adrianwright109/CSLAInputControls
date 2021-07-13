using Csla;
using System;
using System.ComponentModel.DataAnnotations;

namespace NumericTextBox.Shared
{
    [Serializable]
    public class BusinessModel : BusinessBase<BusinessModel>
    {
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
                DefaultTelerikNumericTextBox = 5.00m;
                StandardTelerikNumericTextBox = 10.00m;
                CustomTelerikNumericTextBox = 15.00m;
            }
        }
    }
}
