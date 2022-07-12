using System;

namespace UniversalExamScreen
{
    internal static class Utils
    {
        //Let's code some useful internal utilities to make our work easier

        //Message Manager, these are our private funtions, which will get
        //used throught the simpler internal functions

        private enum MsgIcon
        {
            info,question,error
        }

        private static DialogResult MsgCaller(string txt, MsgBtn btn, MsgIcon ico)
        {
            string mode = (ico == MsgIcon.info) ? "Information." : (ico == MsgIcon.question) ? "Question." : "Error";

            return MessageBox.Show(txt, String.Format("Universal Screen Mode - {0}",mode), (btn == MsgBtn.Ok) ? MessageBoxButtons.OK : MessageBoxButtons.YesNo,
                (ico == MsgIcon.info) ? MessageBoxIcon.Information : (ico == MsgIcon.question) ? MessageBoxIcon.Question : MessageBoxIcon.Error);
        }

        //Internal Message Manager Code

        internal enum MsgBtn
        {
            Ok, YesNo
        }

        internal static DialogResult MsgInfo(string txt, MsgBtn btn)
        {
            return MsgCaller(txt,btn, MsgIcon.info);
        }

        internal static DialogResult MsgQuestion(string txt, MsgBtn btn)
        {
            return MsgCaller(txt, btn, MsgIcon.question);
        }

        internal static DialogResult MsgError(string txt, MsgBtn btn)
        {
            return MsgCaller(txt, btn, MsgIcon.error);
        }

        //Debug viewer

        internal static bool debugMode = true;

        internal static void MsgDebug(string txt)
        {
            if (debugMode)
                MsgQuestion(txt, MsgBtn.Ok);
        }
    }
}
