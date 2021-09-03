using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.Model;
using TMS.IRepository.Personnel;
using DataCommon;

namespace TMS.Repository.Personnel
{
    /// <summary>
    /// 入职办理
    /// </summary>
    public class OnboardingTMS : TMSRepository<StaffModel>, OnboardingITMS
    {
        //添加
        public int OnboardingAdd(StaffModel vm)
        {
            string sql = "insert into staff values (@id,@name,@sex,@phone,@academy,@specialty,@address,@education,@face,@nation,@native_place,@marriage,@birthday,@email,@identity_card,@department,@position,@type,@create_time)";
            int list = Dapper<StaffModel>.RUD(sql, vm);
            return list;
        }
        //删除
        public int OnboardingDel(int id)
        {
            string sql = "DELETE  from staff where id=@id";
            int list = Dapper<StaffModel>.RUD(sql, new { @id = id });
            return list;
        }
        //修改
        public int OnboardingEdit(StaffModel vm)
        {
            string sql = "update staff set name=@name,sex=@sex,phone=@phone,academy=@academy,specialty=@specialty,address=@address,education=@education,face=@face,nation=@nation,native_place=@native_place,marriage=@marriage,birthday=@birthday,email=@email,identity_card=@identity_card,department=@department,position=@position,type=@type,create_time=@create_time where id=@id";
            int list = Dapper<StaffModel>.RUD(sql, vm);
            return list;
        }
        //反添
        public StaffModel OnboardingFt(int id)
        {
            string sql = "select * from staff where id=@id";
            StaffModel list = Dapper<StaffModel>.QueryFirst(sql, new { @id = id });
            return list;
        }
        //显示
        public List<StaffModel> OnboardingShow()
        {
            string sql = "select * from staff";
            List<StaffModel> list = Dapper<StaffModel>.Query(sql);
            return list;
        }
    }
}
