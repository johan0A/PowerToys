// Copyright (c) Microsoft Corporation
// The Microsoft Corporation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Text.Json.Serialization;

namespace Microsoft.PowerToys.Settings.UI.Library
{
    public class GrabAndMoveProperties
    {
        public GrabAndMoveProperties()
        {
            ShouldAbsorbAlt = new BoolProperty(true);
            DoNotActivateOnGameMode = new BoolProperty(true);
            ShowGeometry = new BoolProperty(false);
            UseAltResize = new BoolProperty(true);
            ExcludedApps = new StringProperty();
            ExcludedAppsForModifier = new StringProperty();
            ModifierKey = new IntProperty(0); // 0 = Alt, 1 = Win
            ShowBorder = new BoolProperty(true);
            BorderColor = new StringProperty("#FFB900");
            BorderThickness = new IntProperty(4);
            ShowFill = new BoolProperty(true);
            FillColor = new StringProperty("#FFFFFF");
            FillOpacity = new IntProperty(40);
        }

        [JsonPropertyName("modifierKey")]
        public IntProperty ModifierKey { get; set; }

        [JsonPropertyName("shouldAbsorbAlt")]
        public BoolProperty ShouldAbsorbAlt { get; set; }

        [JsonPropertyName("showGeometry")]
        public BoolProperty ShowGeometry { get; set; }

        [JsonPropertyName("useAltResize")]
        public BoolProperty UseAltResize { get; set; }

        [JsonPropertyName("doNotActivateOnGameMode")]
        public BoolProperty DoNotActivateOnGameMode { get; set; }

        [JsonPropertyName("excluded_apps")]
        public StringProperty ExcludedApps { get; set; }

        [JsonPropertyName("excluded_apps_for_modifier")]
        public StringProperty ExcludedAppsForModifier { get; set; }

        [JsonPropertyName("showBorder")]
        public BoolProperty ShowBorder { get; set; }

        [JsonPropertyName("borderColor")]
        public StringProperty BorderColor { get; set; }

        [JsonPropertyName("borderThickness")]
        public IntProperty BorderThickness { get; set; }

        [JsonPropertyName("showFill")]
        public BoolProperty ShowFill { get; set; }

        [JsonPropertyName("fillColor")]
        public StringProperty FillColor { get; set; }

        [JsonPropertyName("fillOpacity")]
        public IntProperty FillOpacity { get; set; }
    }
}
