﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME.BL
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
            get { return Validate(); }
        }

        public abstract bool Validate();

        //End of Class
    }
}
