# Evil Potion Workshop

## Domain Overview
This is a dark‑themed demon‑themed potion brewing desktop simulation system.
Two custom evil potions are implemented: **Blood‑Red Finger Sacrifice** and **Giant's Resentment**.

### Custom entity attributes
- **Raw Materials**: Vampire Finger, Giant Skull.
  Each material maintains fixed stock quantity stored in program memory.
  Vampire Finger initial stock: 12 units; Giant Skull initial stock: 8 units.
- **Potions**:
  1. Blood‑Red Finger Sacrifice：Requires consuming 2 units of Vampire Finger for each production.
  2. Giant's Resentment：Requires consuming 3 units of Giant Skull for each production.

### Business logic rules implemented
1. Pre‑production inventory validation: Before starting brewing, the system checks whether the current material stock meets the recipe requirement. If stock is insufficient, a warning pop‑up will block the brewing process.
2. Non‑blocking simulated brewing cycle: Uses native `System.Windows.Forms.Timer` together with ProgressBar to simulate brewing progress. The UI window remains responsive and movable during brewing, no program freeze occurs. Total brewing time is fixed at 5 seconds.
3. Automatic inventory deduction: When the brewing progress completes successfully, corresponding raw‑material quantities are automatically subtracted from memory inventory.
4. UI state management: Different text prompts are displayed for three states: ready‑to‑brew, brewing‑in‑progress, and production‑finished. Switching potion recipe will refresh ingredient requirement and stock display.
5. Static thematic hint: A horror‑style static slogan is placed on the top‑right corner of the window to render demon‑worship atmosphere.

## Environment & Setup Instruction
1. Open solution file inside Visual Studio, target framework is .NET Framework 4.8.
2. This project uses in‑memory data storage. No external database required. All inventory data resets after application restart.
3. Form background image can be assigned via WinForms designer `BackgroundImage` property, set `BackgroundImageLayout = Stretch` for full‑window background rendering.
4. Run the project and interact via graphic UI controls.

## How to use
1. Select target potion recipe from the dropdown combobox. Check required ingredient and current stock information.
2. Click `Start` button to launch brewing. ProgressBar visualizes brewing progress. Button will be disabled during brewing.
3. After progress completes, raw‑material stock will decrease automatically. Status text updates to production‑complete demon‑themed message.
4. If material stock is not enough, message box will pop‑up and reject starting the brew.

