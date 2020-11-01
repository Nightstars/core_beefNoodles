using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core_beefNoodles.Models
{
    public static class DbInitialzer
    {
        public static void seed(AppDbContext appDbContext)
        {
            if (appDbContext.Noodles.Any())
            {
                return;
            }
            appDbContext.AddRange
                (
                    new Noodle { Name = "毛细", Price = 12, ShortDescription = "如发丝般细", LongDexcription = "真的好细好细", ImageUrl = "" },
                    new Noodle { Name = "细", Price = 10, ShortDescription = "普通细", LongDexcription = "还是挺细的", ImageUrl = "" },
                    new Noodle { Name = "三细", Price = 11, ShortDescription = "有点粗了", LongDexcription = "比细的粗点，比粗的细点", ImageUrl = "" },
                    new Noodle { Name = "二细", Price = 10, ShortDescription = "粗了", LongDexcription = "粗的才有嚼劲", ImageUrl = "" },
                    new Noodle { Name = "二柱子", Price = 11, ShortDescription = "太粗了", LongDexcription = "粗得快咬不动了", ImageUrl = "" },
                    new Noodle { Name = "韭叶子", Price = 12, ShortDescription = "扁的", LongDexcription = "韭菜叶一样宽", ImageUrl = "" },
                    new Noodle { Name = "薄宽", Price = 11, ShortDescription = "开始宽了", LongDexcription = "比韭菜叶宽一点", ImageUrl = "" },
                    new Noodle { Name = "大宽", Price = 10, ShortDescription = "裤带面", LongDexcription = "比嘴还宽了", ImageUrl = "" },
                    new Noodle { Name = "荞麦棱子", Price = 15, ShortDescription = "立方体的", LongDexcription = "好像知道是方的", ImageUrl = "" },
                    new Noodle { Name = "一窝丝", Price = 15, ShortDescription = "这是啥", LongDexcription = "我也没吃过", ImageUrl = "" }
                );
            appDbContext.SaveChanges();
        }
    }
}
