using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace Sujay 
{
    class SujayInput
    {
        public GamePadState g = GamePad.GetState(PlayerIndex.One);
        public GamePadState og = GamePad.GetState(PlayerIndex.One);

        public KeyboardState kb = Keyboard.GetState();
        public KeyboardState okb = Keyboard.GetState();

        public SujayInput()
        {

        }

        public void update1()
        {
            g = GamePad.GetState(PlayerIndex.One);
            kb = Keyboard.GetState();
        }

        public void update2()
        {
            og = GamePad.GetState(PlayerIndex.One);
            okb = Keyboard.GetState();
        }

        public bool keyEvent(Keys key)
        {
            return kb.IsKeyDown(key) && okb.IsKeyUp(key);
        }

        public bool leftEvent()
        {
            bool gInput = g.DPad.Left == ButtonState.Pressed && og.DPad.Left == ButtonState.Released;
            bool kbInput = kb.IsKeyDown(Keys.Left) && okb.IsKeyUp(Keys.Left);
            return gInput || kbInput;
        }

        public bool rightEvent()
        {
            bool gInput = g.DPad.Right == ButtonState.Pressed && og.DPad.Right == ButtonState.Released;
            bool kbInput = kb.IsKeyDown(Keys.Right) && okb.IsKeyUp(Keys.Right);
            return gInput || kbInput;
        }

        public bool startEvent()
        {
            bool gInput = g.Buttons.Start == ButtonState.Pressed && og.Buttons.Start == ButtonState.Released;
            bool kbInput = kb.IsKeyDown(Keys.Enter) && okb.IsKeyUp(Keys.Enter);
            return gInput || kbInput;
        }

        public bool backEvent()
        {
            bool gInput = g.Buttons.Back == ButtonState.Pressed && og.Buttons.Back == ButtonState.Released;
            bool kbInput = kb.IsKeyDown(Keys.Back) && okb.IsKeyUp(Keys.Back);
            return gInput || kbInput;
        }
    }
}
