using Microsoft.EntityFrameworkCore;
using StudyPlatform.BL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace StudyPlatform.BL.Services
{
    public class LiteDbContext : DbContext
    {
        public DbSet<User> Users => Set<User>();
        //public DbSet<Chat> Chats => Set<Chat>();
        //public DbSet<Comment> Comments => Set<Comment>();
        //public DbSet<Files> Files => Set<Files>();
        //public DbSet<Group> Groups => Set<Group>();
        //public DbSet<GroupChat> GroupChats => Set<GroupChat>();
        //public DbSet<GroupedUsers> GroupedUsers => Set<GroupedUsers>();
        public DbSet<Homework> Homeworks => Set<Homework>();
        //public DbSet<Lecture> Lectures => Set<Lecture>();
        //public DbSet<LecturePlan> LecturePlans => Set<LecturePlan>();
        //public DbSet<LectureStatus> LectureStatuses => Set<LectureStatus>();
        //public DbSet<Message> Messages => Set<Message>();
        public DbSet<MessageStatus> MessageStatuses => Set<MessageStatus>();
        //public DbSet<Notification> Notifications => Set<Notification>();
        //public DbSet<Post> Posts => Set<Post>();
        public DbSet<Role> Roles => Set<Role>();
        public DbSet<Tasks> Tasks => Set<Tasks>();
        public DbSet<TaskStatuses> TaskStatuses => Set<TaskStatuses>();
        //public DbSet<VisitLecture> VisitLectures => Set<VisitLecture>();
        public LiteDbContext(){
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlite("Data Source=TestingDb.db");
        }
    }
}
