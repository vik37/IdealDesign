using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace IdealDesign_WebModels.EnumsVM
{
    public enum ProductTypeVM
    {
        [Description("Kitchens")]
        Kitchens,
        [Description("Wardrobes")]
        Wardrobes,
        [Description("Bathroom Furniture")]
        BathroomFurniture,
        [Description("Living Room Furniture")]
        LivingRoomFurniture,
        [Description("WallBeds")]
        WallBeds,
        [Description("Childrens Furniture")]
        ChildrensFurniture,
        [Description("Other")]
        Other
    }
}
