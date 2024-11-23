using System;
using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;
using WebSocketSharp;

namespace ChatClient
{
    public partial class LogPage : Window
    {
        private static LogPage _instance;
        private static RichTextBox _logRichTextBox;  // 使用 RichTextBox 来存储日志输出的目标

        // 私有构造函数，防止外部直接创建实例
        private LogPage()
        {
            InitializeComponent();
            _logRichTextBox = LogRichTextBox; // 关联到界面的 RichTextBox
        }

        // 静态属性来获取单例
        public static LogPage Instance
        {
            get
            {
                // 如果实例为空，则创建实例
                if (_instance == null)
                {
                    _instance = new LogPage();
                    _instance.Show();  // 自动显示 LogPage
                }
                return _instance;
            }
        }

        // 静态 Log 方法，可以在应用的任何地方调用
        public static void Log(string message, LogLevel logLevel = LogLevel.Info)
        {
            // 确保 LogPage 已经创建并可用于显示日志
            if (_instance == null)
            {
                // 如果 LogPage 尚未初始化，创建并显示 LogPage
                _instance = Instance;  // 通过 Instance 确保 LogPage 被创建
                Console.WriteLine($"LogPage not initialized yet: {message}");  // 临时日志记录
                return;  // 退出，不再做递归调用
            }

            // 获取当前时间
            string time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffff");

            // 获取调用栈，获取文件名和行号
            var stackFrame = new StackFrame(1, true);  // 1 表示上层调用
            string fileName = stackFrame.GetFileName();  // 获取源文件名（相对路径）
            int lineNumber = stackFrame.GetFileLineNumber();  // 获取行号

            // 如果文件名为 null，说明无法定位源代码文件
            fileName = fileName ?? "UnknownFile";

            // 格式化日志字符串
            string formattedMessage = $"[{time}][{logLevel}][{fileName}:{lineNumber}] - {message}";

            // 使用 Dispatcher 确保线程安全地更新 UI
            _instance.Dispatcher.Invoke(() =>
            {
                // 根据不同的日志级别设置颜色
                Brush color = Brushes.Black;  // 默认文本颜色

                switch (logLevel)
                {
                    case LogLevel.Debug:
                        color = Brushes.Gray;
                        break;
                    case LogLevel.Info:
                        color = Brushes.Green;
                        break;
                    case LogLevel.Warn:
                        color = Brushes.Yellow;
                        break;
                    case LogLevel.Error:
                        color = Brushes.Red;
                        break;
                    case LogLevel.Fatal:
                        color = Brushes.DarkRed;
                        break;
                }

                // 创建一个新的 Paragraph，并设置日志文本
                Paragraph paragraph = new Paragraph(new Run(formattedMessage))
                {
                    Foreground = color,  // 设置文本颜色
                    Margin = new Thickness(0)  // 设置段落外边距为 0，避免段落之间有额外空隙
                };

                // 将文本段落插入到 RichTextBox 中
                _logRichTextBox.Document.Blocks.Add(paragraph);

                // 滚动到最新日志
                _logRichTextBox.ScrollToEnd();  // 自动滚动到文本框的底部，显示最新的日志
            });
        }

        // 防止在应用程序结束时窗口关闭，确保实例保持
        protected override void OnClosed(System.EventArgs e)
        {
            base.OnClosed(e);
            _instance = null; // 关闭时清理单例
        }
    }
}
