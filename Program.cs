using System;

/// <summary>
/// プログラムのエントリーポイントを提供するクラスです。
/// </summary>
class Program
{
    /// <summary>
    /// プログラムのエントリーポイントです。
    /// </summary>
    static void Main()
    {
        // シングルトンインスタンスを取得します。
        Singleton singleton = Singleton.Instance;

        // メソッドを呼び出します。
        singleton.ShowStatus();

        // もう一度インスタンスを取得して同じインスタンスであることを確認します。
        Singleton anotherSingleton = Singleton.Instance;
        Console.WriteLine(object.ReferenceEquals(singleton, anotherSingleton)); // True

    }
}