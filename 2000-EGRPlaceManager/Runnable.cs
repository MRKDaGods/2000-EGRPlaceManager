using System;
using System.Collections.Generic;
using System.Threading;

namespace MRK {
    public class Runnable {
        Thread m_Thread;
        readonly List<Action> m_Queue;

        public Runnable(Thread thread) {
            m_Thread = thread;
            m_Queue = new List<Action>();
        }

        public void Run(Action action) {
            if (action == null) {
                return;
            }

            if (Thread.CurrentThread == m_Thread) {
                action();
                return;
            }

            lock (m_Queue) {
                m_Queue.Add(action);
            }
        }

        public void Update() {
            if (Thread.CurrentThread == m_Thread) {
                lock (m_Queue) {
                    foreach (Action action in m_Queue) {
                        action();
                    }

                    m_Queue.Clear();
                }
            }
        }

        public static void RunOnUIThread(Action action) {
            Main.Instance.UIRunnable.Run(action);
        }
    }
}
