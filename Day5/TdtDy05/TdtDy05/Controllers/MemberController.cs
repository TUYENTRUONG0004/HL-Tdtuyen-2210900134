using Microsoft.AspNetCore.Mvc; // Hoặc System.Web.Mvc nếu .NET Framework
using TdtDy04.Models.DataModels;
using System.Collections.Generic;

namespace TdtDy04.Controllers
{
    public class MemberController : Controller
    {
        private static List<Member> _members = new List<Member>(); // Danh sách tĩnh

        // B1: Hiển thị danh sách thành viên
        public ActionResult GetMembers()
        {
            if (!_members.Any())
            {
                _members.Add(new Member { MemberId = Guid.NewGuid().ToString(), Username = "member1", Fullname = "Thanh viên 1", Password = "123456", Email = "loc@gmail.com" });
                _members.Add(new Member { MemberId = Guid.NewGuid().ToString(), Username = "member2", Fullname = "Thanh viên 2", Password = "123456", Email = "loc@gmail.com" });
                _members.Add(new Member { MemberId = Guid.NewGuid().ToString(), Username = "Tuyen", Fullname = "Truong Dinh Tuyen", Password = "123456", Email = "loc4571@gmail.com" });
            }
            ViewBag.members = _members;
            return View();
        }

        // B3: Hiển thị form thêm (GET Create)
        public ActionResult Create()
        {
            return View();
        }

        // B3: Xử lý thêm (POST Create)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Member member)
        {
            if (ModelState.IsValid)
            {
                if (string.IsNullOrEmpty(member.MemberId))
                    member.MemberId = Guid.NewGuid().ToString();

                _members.Add(member);
                ViewBag.members = _members; // Cập nhật ViewBag sau khi thêm
                TempData["Success"] = "Thêm thành viên thành công!";
                return RedirectToAction("GetMembers");
            }
            // Nếu không hợp lệ, giữ ViewBag để hiển thị lại
            ViewBag.members = _members;
            return View(member);
        }
    }
}