﻿using HybridBridge.WinForm.Samples.Models;

namespace HybridBridge.WinForm.Samples.Controllers
{
    internal class PropertySamplesController
    {
        public static SampleModel ComplexField = null;
        public int IntProperty { get; set; } = 5;

        public string ReadOnlyProperty
        {
            // ReSharper disable once ConvertPropertyToExpressionBody
            get
            {
                return ComplexField?.StringValue ?? "ComplexField is null, can't read the StringValue property to return";
            }
        }
    }
}