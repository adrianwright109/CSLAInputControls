using System;
using Csla.Core;
using Csla.Serialization.Mobile;
using Telerik.DataSource;

namespace CSLAInputControls.Common.TelerikWrappersForCslaSerialization
{
    [Serializable]
    public class DataSourceRequestWrapper : MobileObject
    {
        /// <summary>
        /// <see cref="DataSourceRequest"/> serialised as a UTF-8 JSON byte array
        /// using <see cref="System.Text.Json.JsonSerializer"/>.
        /// </summary>
        public byte[] DataSourceRequestAsJson { get; set; }

        #region MobileObject overrides for Serialization and De-Serialization

        protected override void OnGetState(SerializationInfo info, StateMode mode)
        {
            base.OnGetState(info, mode);

            info.AddValue(nameof(DataSourceRequestAsJson), DataSourceRequestAsJson);
        }

        protected override void OnSetState(SerializationInfo info, StateMode mode)
        {
            base.OnSetState(info, mode);

            DataSourceRequestAsJson = info.GetValue<byte[]>(nameof(DataSourceRequestAsJson));
        }

        #endregion MobileObject overrides for Serialization and De-Serialization
    }
}
