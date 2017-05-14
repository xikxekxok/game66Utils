using System;

namespace game66Utils.Catalog.Query.SimularGroup
{
    public class SimularGroupDto
    {
        public Guid GroupId { get; set; }
        public string GroupTitle { get; set; }
        public override string ToString()
        {
            return GroupTitle;
        }
    }
}