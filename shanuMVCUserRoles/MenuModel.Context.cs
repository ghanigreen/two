﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace shanuMVCUserRoles
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class AttendanceDBEntities : DbContext
    {
        public AttendanceDBEntities()
            : base("name=AttendanceDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<MenuMaster> MenuMaster { get; set; }
    
        public virtual int USP_Menu_Delete(Nullable<int> menuIdentity)
        {
            var menuIdentityParameter = menuIdentity.HasValue ?
                new ObjectParameter("MenuIdentity", menuIdentity) :
                new ObjectParameter("MenuIdentity", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_Menu_Delete", menuIdentityParameter);
        }
    
        public virtual ObjectResult<string> USP_Menu_Insert(string menuID, string menuName, string parent_MenuID, string user_Roll, string menuFileName, string menuURL, string uSE_YN)
        {
            var menuIDParameter = menuID != null ?
                new ObjectParameter("MenuID", menuID) :
                new ObjectParameter("MenuID", typeof(string));
    
            var menuNameParameter = menuName != null ?
                new ObjectParameter("MenuName", menuName) :
                new ObjectParameter("MenuName", typeof(string));
    
            var parent_MenuIDParameter = parent_MenuID != null ?
                new ObjectParameter("Parent_MenuID", parent_MenuID) :
                new ObjectParameter("Parent_MenuID", typeof(string));
    
            var user_RollParameter = user_Roll != null ?
                new ObjectParameter("User_Roll", user_Roll) :
                new ObjectParameter("User_Roll", typeof(string));
    
            var menuFileNameParameter = menuFileName != null ?
                new ObjectParameter("MenuFileName", menuFileName) :
                new ObjectParameter("MenuFileName", typeof(string));
    
            var menuURLParameter = menuURL != null ?
                new ObjectParameter("MenuURL", menuURL) :
                new ObjectParameter("MenuURL", typeof(string));
    
            var uSE_YNParameter = uSE_YN != null ?
                new ObjectParameter("USE_YN", uSE_YN) :
                new ObjectParameter("USE_YN", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("USP_Menu_Insert", menuIDParameter, menuNameParameter, parent_MenuIDParameter, user_RollParameter, menuFileNameParameter, menuURLParameter, uSE_YNParameter);
        }
    
        public virtual ObjectResult<USP_Menu_Select_Result> USP_Menu_Select(string menuID, string menuName)
        {
            var menuIDParameter = menuID != null ?
                new ObjectParameter("MenuID", menuID) :
                new ObjectParameter("MenuID", typeof(string));
    
            var menuNameParameter = menuName != null ?
                new ObjectParameter("MenuName", menuName) :
                new ObjectParameter("MenuName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_Menu_Select_Result>("USP_Menu_Select", menuIDParameter, menuNameParameter);
        }
    
        public virtual ObjectResult<string> USP_Menu_Update(Nullable<int> menuIdentity, string menuID, string menuName, string parent_MenuID, string user_Roll, string menuFileName, string menuURL, string uSE_YN)
        {
            var menuIdentityParameter = menuIdentity.HasValue ?
                new ObjectParameter("MenuIdentity", menuIdentity) :
                new ObjectParameter("MenuIdentity", typeof(int));
    
            var menuIDParameter = menuID != null ?
                new ObjectParameter("MenuID", menuID) :
                new ObjectParameter("MenuID", typeof(string));
    
            var menuNameParameter = menuName != null ?
                new ObjectParameter("MenuName", menuName) :
                new ObjectParameter("MenuName", typeof(string));
    
            var parent_MenuIDParameter = parent_MenuID != null ?
                new ObjectParameter("Parent_MenuID", parent_MenuID) :
                new ObjectParameter("Parent_MenuID", typeof(string));
    
            var user_RollParameter = user_Roll != null ?
                new ObjectParameter("User_Roll", user_Roll) :
                new ObjectParameter("User_Roll", typeof(string));
    
            var menuFileNameParameter = menuFileName != null ?
                new ObjectParameter("MenuFileName", menuFileName) :
                new ObjectParameter("MenuFileName", typeof(string));
    
            var menuURLParameter = menuURL != null ?
                new ObjectParameter("MenuURL", menuURL) :
                new ObjectParameter("MenuURL", typeof(string));
    
            var uSE_YNParameter = uSE_YN != null ?
                new ObjectParameter("USE_YN", uSE_YN) :
                new ObjectParameter("USE_YN", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("USP_Menu_Update", menuIdentityParameter, menuIDParameter, menuNameParameter, parent_MenuIDParameter, user_RollParameter, menuFileNameParameter, menuURLParameter, uSE_YNParameter);
        }
    
        public virtual ObjectResult<USP_UserRoles_Select_Result> USP_UserRoles_Select(string rolename)
        {
            var rolenameParameter = rolename != null ?
                new ObjectParameter("Rolename", rolename) :
                new ObjectParameter("Rolename", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_UserRoles_Select_Result>("USP_UserRoles_Select", rolenameParameter);
        }
    }
}