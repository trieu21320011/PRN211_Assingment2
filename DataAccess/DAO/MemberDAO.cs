using BusinessObject;

namespace DataAccess.DAO
{
    public class MemberDAO
    {
        private static MemberDAO instance = null;
        private static readonly object instanceLock = new();
        private Assignment2_PRN211Context DBContext = new();
        public static MemberDAO getInstance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null) instance = new MemberDAO();
                    return instance;
                }
            }
        }

        public List<Member> GetMemberList() => DBContext.Members.ToList();

        public Member GetMemberByID(int memberID)
            => DBContext.Members.Find(memberID)
            ?? throw new ArgumentNullException();

        public Member? GetMemberByEmail(string memberEmail)
        {
            var members = GetMemberList();
            Member member = null;
            foreach (var x in members) if (x.Email.Equals(memberEmail)) member = x;

            return member;
        }

        public void AddNew(Member member)
        {
            if (GetMemberByID(member.MemberId) == null)
            {
                DBContext.Members.Add(member);
                DBContext.SaveChanges();
            }
            else throw new Exception("Member is already exists.");
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
            else throw new Exception("Member is not exist.");
        }

        public void Remove(int memberID)
        {
            var member = GetMemberByID(memberID);
            DBContext.Remove(member);
            DBContext.SaveChanges();
        }

        public Member? CheckLogin(string email, string password)
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
