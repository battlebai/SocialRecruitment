﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Langben.DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SysEntities : DbContext
    {
        public SysEntities()
            : base("name=SysEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Account> Account { get; set; }
        public virtual DbSet<Blog> Blog { get; set; }
        public virtual DbSet<Comment> Comment { get; set; }
        public virtual DbSet<DegreeSchool> DegreeSchool { get; set; }
        public virtual DbSet<FileUploader> FileUploader { get; set; }
        public virtual DbSet<InternshipExperience> InternshipExperience { get; set; }
        public virtual DbSet<ITAbility> ITAbility { get; set; }
        public virtual DbSet<LanguageCompetence> LanguageCompetence { get; set; }
        public virtual DbSet<ProjectExperience> ProjectExperience { get; set; }
        public virtual DbSet<Resume> Resume { get; set; }
        public virtual DbSet<SysAnnouncement> SysAnnouncement { get; set; }
        public virtual DbSet<SysException> SysException { get; set; }
        public virtual DbSet<SysField> SysField { get; set; }
        public virtual DbSet<SysLog> SysLog { get; set; }
        public virtual DbSet<SysNotice> SysNotice { get; set; }
    }
}
