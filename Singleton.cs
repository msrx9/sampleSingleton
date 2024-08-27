using System;

/// <summary>
/// シングルトンパターンを実現するクラスです。
/// </summary>
public sealed class Singleton
{
    private static readonly Singleton instance = new Singleton();

    // コンストラクタを private にして外部からのインスタンス生成を防ぎます。
    private Singleton() { }

    /// <summary>
    /// シングルトンインスタンスを取得します。
    /// </summary>
    public static Singleton Instance
    {
        get
        {
            return instance;
        }
    }

    /// <summary>
    /// 動作していることを示すメッセージをコンソールに出力します。
    /// </summary>
    public void ShowStatus()
    {
        Console.WriteLine("Singleton instance is working.");
    }
}