using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.FileProviders;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Poetry.Poetry
{
    public class PoetryDataSeederContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<PoetryClassify, Guid> _poetryClassifyDataRepository;
        private readonly IRepository<PoetryData, Guid> _poetryDataRepository;
        public PoetryDataSeederContributor(IRepository<PoetryClassify, Guid> poetryClassifyDataRepository, IRepository<PoetryData, Guid> poetryDataRepository)
        {
            _poetryClassifyDataRepository = poetryClassifyDataRepository;
            _poetryDataRepository = poetryDataRepository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            //获取项目路径
            var path = Directory.GetCurrentDirectory();
            //种子数据路径
            var filePath = Path.Combine(path, "Poetry", "诗词");
            //文件提供者 提供物理文件
            IFileProvider provider = new PhysicalFileProvider(filePath);
            IDirectoryContents contents = provider.GetDirectoryContents(string.Empty);
            foreach (var item in contents)
            {
                //古诗三百首...目录
                IDirectoryContents pr = provider.GetDirectoryContents(item.Name);
                foreach (var item2 in pr)
                {
                    //判断：文件还是目录
                    if (!(item2.IsDirectory))
                    {
                        var builder = new ConfigurationBuilder();
                        builder.AddJsonFile(item2.PhysicalPath);
                        var configuration = builder.Build();



                        if (await _poetryClassifyDataRepository.GetCountAsync() <= 5)
                        {
                            

                            for (int i = 0; true; i++)
                            {
                                string id = configuration.GetSection($"listTitle:{i}:id").Get<string>();
                                string title = configuration.GetSection($"listTitle:{i}:title").Get<string>();
                                if (id.IsNullOrEmpty())
                                {
                                    break;
                                }
                                await _poetryClassifyDataRepository.InsertAsync(new PoetryClassify { MyId = id,MyType= item2.Name.Split('.')[0], Name = title }, autoSave: true);
                            }
                        }


                    }
                    else
                    {
                        if (await _poetryDataRepository.GetCountAsync() <= 5)
                        {
                            //dada目录
                            IDirectoryContents pr2 = provider.GetDirectoryContents(Path.Combine(item.Name,item2.Name));
                            foreach (var item3 in pr2)
                            {
                                var builder = new ConfigurationBuilder();
                                builder.AddJsonFile(item3.PhysicalPath);
                                var configuration = builder.Build();

                                var id=configuration["id"];
                                var title = configuration["title"];
                                var author = configuration["author"];
                                var period = configuration["period"];
                                var content = configuration["content"];
                                var list = configuration["list"];
                                await _poetryDataRepository.InsertAsync(new PoetryData { MyId = id,Title=title,Author=author,Period=period,Content=content,List=list}, autoSave: true);

                            }
                        }
                    }
                }
            }
            
            //if (await _poetryClassifyDataRepository.GetCountAsync() <= 0)
            //{
            //    await _poetryClassifyDataRepository.InsertAsync(
            //        new Book
            //        {
            //            Name = "1984",
            //            Type = BookType.Dystopia,
            //            PublishDate = new DateTime(1949, 6, 8),
            //            Price = 19.84f
            //        },
            //        autoSave: true
            //    );


            //}
        }
    }
}
