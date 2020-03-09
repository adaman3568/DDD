using DDD.Infrastructure.Model;

namespace DDD.WinForm.Adonet
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class DDDStudyContext : DbContext
    {
        // コンテキストは、アプリケーションの構成ファイル (App.config または Web.config) から 'DDDStudyContext' 
        // 接続文字列を使用するように構成されています。既定では、この接続文字列は LocalDb インスタンス上
        // の 'DDD.WinForm.Ado.net.DDDStudyContext' データベースを対象としています。 
        // 
        // 別のデータベースとデータベース プロバイダーまたはそのいずれかを対象とする場合は、
        // アプリケーション構成ファイルで 'DDDStudyContext' 接続文字列を変更してください。
        public DDDStudyContext()
            : base("name=DDDStudyContext")
        {
        }

        // モデルに含めるエンティティ型ごとに DbSet を追加します。Code First モデルの構成および使用の
        // 詳細については、http://go.microsoft.com/fwlink/?LinkId=390109 を参照してください。

        public DbSet<Car> Cars { get; set; }
    }
}