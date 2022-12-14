using BusinessObject;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class MemberDAO
    {
        private static MemberDAO instance = null;
        private static readonly object instanceLock = new object();
        Assignment2_PRN211Context DBContext = new Assignment2_PRN211Context();

        public static MemberDAO getInstance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new MemberDAO();
                    }
                    return instance;
                }
            }
        }

        public List<Member> GetMemberList() => DBContext.Members.ToList();

        public Member GetMemberByID(int memberID) => DBContext.Members.Find(memberID);
        public Member GetMemberByEmail(string memberEmail)
        {
            var members = GetMemberList();

            Member member = null;

            foreach (var mem in members)
            {
                if (mem.Email.Equals(memberEmail))
                {
                    member = mem;
                }
            }
            return member;
        }

        public void AddNew(Member member)
        {
            if (GetMemberByID(member.MemberId) == null)
            {
                DBContext.Members.Add(member);
                DBContext.SaveChanges();
            }
            else
            {
                throw new Exception("Member is already exists.");
            }
        }

        public void Update(Member member)
        {
            var memberUpdate = GetMemberByID(member.MemberId);
            if (memberUpdate != null)
            {
                memberUpdate.MemberId = member.MemberId;
                memberUpdate.CompanyName = member.CompanyName;
                memberUpdate.Email = member.Email;
                memberUpdate.City = member.City;
                memberUpdate.Country = member.Country;
                memberUpdate.Password = member.Password;
                DBContext.Update(memberUpdate);
                DBContext.SaveChanges();
            }
            else
            {
                throw new Exception("Member is not exist.");
            }
        }

        public void Remove(int memberID)
        {
            var member = GetMemberByID(memberID);

            DBContext.Remove(member);
            DBContext.SaveChanges();
        }

        public Member CheckLogin(string email, string password)
        {
            Member loginMember = null;
            

            var members = GetMemberList();

            foreach (var member in members)
            {
                if (member.Email.Equals(email) && member.Password.Equals(password))
                {
                    loginMember = member;
                    return loginMember;
                }
            }
            return loginMember;
        }

    }
}
