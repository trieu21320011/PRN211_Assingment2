using BusinessObject;
using DataAccess.DAO;
using DataAccess.Repository.Interface;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        public Member CheckLogin(string email, string password) => MemberDAO.getInstance.CheckLogin(email, password);
        public void DeleteMember(int memberID) => MemberDAO.getInstance.Remove(memberID);
        public Member GetMemberByID(int memberID) => MemberDAO.getInstance.GetMemberByID(memberID);
        public Member GetMemberByEmail(string memberEmail) => MemberDAO.getInstance.GetMemberByEmail(memberEmail);
        public IEnumerable<Member> GetMembers() => MemberDAO.getInstance.GetMemberList();
        public void InsertMember(Member member) => MemberDAO.getInstance.AddNew(member);
        public void UpdateMember(Member member) => MemberDAO.getInstance.Update(member);
    }
}
