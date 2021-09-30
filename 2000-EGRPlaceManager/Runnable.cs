using System;
using System.Collections.Generic;
using System.Threading;

namespace MRK {
    public class Runnable {
        struct Queued {
            public Action Action;
            public CancellationToken? Token;
        }

        Thread m_Thread;
        readonly List<Queued> m_Queue;

        public Runnable(Thread thread) {
            m_Thread = thread;
            m_Queue = new List<Queued>();
        }

        public void Run(Action action, CancellationToken? token) {
            if (action == null) {
                return;
            }

            if (Thread.CurrentThread == m_Thread) {
                action();
                return;
            }

            lock (m_Queue) {
                m_Queue.Add(new Queued { Action = action, Token = token });
            }
        }

        public void Update() {
            if (Thread.CurrentThread == m_Thread) {
                lock (m_Queue) {
                    foreach (Queued action in m_Queue) {
                        if (action.Token.HasValue && action.Token.Value.IsCancellationRequested) {
                            continue;
                        }

                        action.Action();
                    }

                    m_Queue.Clear();
                }
            }
        }

        public static void RunOnUIThread(Action action, CancellationToken? token = null) {
            Main.Instance.UIRunnable.Run(action, token);
        }
    }
}
