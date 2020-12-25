using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
#nullable enable

namespace Blanks.Container
{
    /// <summary>
    /// バイト配列を保有する有向木構造を提供します。複数の子要素に対し、単一の親要素で示します。
    /// </summary>
    /// <typeparam name="ImplClass">この抽象クラスを実装するクラス。
    /// 型制限において記述されています。</typeparam>
    public abstract partial class AbstractByteTreeLeaf<ImplClass>
        where ImplClass : notnull, AbstractByteTreeLeaf<ImplClass>
    {
        /// <summary>
        /// このインスタンスが保有する子要素。
        /// </summary>
        protected List<AbstractByteTreeLeaf<ImplClass>> Children { get; set; }
        /// <summary>
        /// このインスタンスを保有する親要素。
        /// このインスタンスが最上位要素である場合は<see cref="null"/>を示します。
        /// </summary>
        protected AbstractByteTreeLeaf<ImplClass>? Parent { get; private set; }
        /// <summary>
        /// このインスタンスが内包しているバイト配列。
        /// </summary>
        protected abstract Stream InitializedStream();

    }
}
