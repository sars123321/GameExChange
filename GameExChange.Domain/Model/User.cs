﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameExChange.Domain.Model
{
    /// <summary>
    /// 用户表
    /// </summary>
    public class User : AggregateRoot
    {

        #region database columns
        /// <summary>
        /// Id
        /// </summary>		
        public int Id { get; set; }
        /// <summary>
        /// UserName
        /// </summary>		
        public string UserName { get; set; }
        /// <summary>
        /// Password
        /// </summary>		
        public string Password { get; set; }
        /// <summary>
        /// Province
        /// </summary>		
        public string Province { get; set; }
        /// <summary>
        /// Nationality
        /// </summary>		
        public string Nationality { get; set; }
        /// <summary>
        /// City
        /// </summary>		
        public string City { get; set; }
        /// <summary>
        /// Address
        /// </summary>		
        public string Address { get; set; }
        /// <summary>
        /// Remark
        /// </summary>		
        public string Remark { get; set; }
        /// <summary>
        /// 是否为管理员
        /// </summary>		
        public bool IsAdmin { get; set; }
        /// <summary>
        /// QQ
        /// </summary>		
        public string QQ { get; set; }
        /// <summary>
        /// Email
        /// </summary>		
        public string Email { get; set; }
        /// <summary>
        /// Phone
        /// </summary>		
        public string Phone { get; set; }
        #endregion

        #region  Public Methods

        #endregion
    }
}