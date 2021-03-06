﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core_beefNoodles.Models
{
    public class MockNoodleRepository : INoodleRepository
    {
        private List<Noodle> _noodles;

        public MockNoodleRepository()
        {
            if(_noodles==null)
            {
                InitializeNoodle();
            }
        }

        public IEnumerable<Noodle> GetAllNoodles()
        {
            return _noodles;
        }

        public Noodle GetNoodleById(int id)
        {
            return _noodles.FirstOrDefault(n =>n.Id==id);
        }

        private void InitializeNoodle()
        {
            _noodles = new List<Noodle>
            {
                new Noodle { Id=1,Name="毛细",Price=12,ShortDescription="如发丝般细",LongDexcription="真的好细好细",ImageUrl=""},
                new Noodle { Id=2,Name="细",Price=10,ShortDescription="普通细",LongDexcription="还是挺细的",ImageUrl=""},
                new Noodle { Id=3,Name="三细",Price=11,ShortDescription="有点粗了",LongDexcription="比细的粗点，比粗的细点",ImageUrl=""},
                new Noodle { Id=4,Name="二细",Price=10,ShortDescription="粗了",LongDexcription="粗的才有嚼劲",ImageUrl=""},
                new Noodle { Id=5,Name="二柱子",Price=11,ShortDescription="太粗了",LongDexcription="粗得快咬不动了",ImageUrl=""},
                new Noodle { Id=6,Name="韭叶子",Price=12,ShortDescription="扁的",LongDexcription="韭菜叶一样宽",ImageUrl=""},
                new Noodle { Id=7,Name="薄宽",Price=11,ShortDescription="开始宽了",LongDexcription="比韭菜叶宽一点",ImageUrl=""},
                new Noodle { Id=8,Name="大宽",Price=10,ShortDescription="裤带面",LongDexcription="比嘴还宽了",ImageUrl=""},
                new Noodle { Id=9,Name="荞麦棱子",Price=15,ShortDescription="立方体的",LongDexcription="好像知道是方的",ImageUrl=""},
                new Noodle { Id=10,Name="一窝丝",Price=15,ShortDescription="这是啥",LongDexcription="我也没吃过",ImageUrl=""},
            };
        }
    }
}
