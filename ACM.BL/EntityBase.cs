using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public abstract class EntityBase
    {
        /// <summary>
        /// Identifies is this a new item
        /// </summary>
        public bool IsNew { get; private set; }

        /// <summary>
        /// Identifies if entity was changed
        /// </summary>
        public bool HasChanges { get; private set; }

        /// <summary>
        /// Returns the state: active, deleted
        /// </summary>
        public EntityStateOption EntityState { get; set; }

        /// <summary>
        /// Is valid object/entity
        /// </summary>
        public bool IsValid
        {
            //TODO: replase this code with the real logic
            get { return true; }
        }

        //End of Class
    }
}
