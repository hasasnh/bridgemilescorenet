﻿using OrchardCore.ContentFields.Fields;
using OrchardCore.ContentManagement;
using System;


namespace Bridgemiles.Core.Net.Menu.Models
{
    public class Employee : ContentPart
    {
        public LinkField link { get; set; }
        public ContentPickerField logo { get; set; }
    }
}
