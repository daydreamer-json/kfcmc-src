﻿/// <summary>
/// string 型の汎用関数を管理するクラス
/// </summary>
public static class StringUtils {
    /// <summary>
    /// 指定された形式に基づいてオブジェクトの値を文字列に変換し、別の文字列に挿入します
    /// </summary>
    public static string Format<T1>(string format, T1 arg1) {
        return string.Format(
            format,
            arg1.ToString()
        );
    }

    /// <summary>
    /// 指定された形式に基づいてオブジェクトの値を文字列に変換し、別の文字列に挿入します
    /// </summary>
    public static string Format<T1, T2>(string format, T1 arg1, T2 arg2) {
        return string.Format(
            format,
            arg1.ToString(),
            arg2.ToString()
        );
    }

    /// <summary>
    /// 指定された形式に基づいてオブジェクトの値を文字列に変換し、別の文字列に挿入します
    /// </summary>
    public static string Format<T1, T2, T3>(string format, T1 arg1, T2 arg2, T3 arg3) {
        return string.Format(
            format,
            arg1.ToString(),
            arg2.ToString(),
            arg3.ToString()
        );
    }

    /// <summary>
    /// 指定された形式に基づいてオブジェクトの値を文字列に変換し、別の文字列に挿入します
    /// </summary>
    public static string Format<T1, T2, T3, T4>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4) {
        return string.Format(
            format,
            arg1.ToString(),
            arg2.ToString(),
            arg3.ToString(),
            arg4.ToString()
        );
    }
}