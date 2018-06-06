using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pdcaAssistApp {
    public partial class pdcaMainForm : Form {

        #region Fields

        #region Constants

        /* Status */
        private const int STATUS_CASE_UNLOAD = 0;       /* Case 未設定時 */
        private const int STATUS_PROGRESS_PLAN = 1;     /* Case Plan時   */
        private const int STATUS_PROGRESS_DO = 2;       /* Case Do時     */
        private const int STATUS_PROGRESS_CHECK = 3;    /* Case Check時  */
        private const int STATUS_PROGRESS_ACT = 4;      /* Case Act時    */

        /* Control Id */
        private const int CTRL_RADIO_PLAN = 0;
        private const int CTRL_RADIO_DO = 1;
        private const int CTRL_RADIO_CHECK = 2;
        private const int CTRL_RADIO_ACT = 3;
        private const int CTRL_BUTTON_INHERIT = 4;
        private const int CTRL_BUTTON_N_STAGE = 5;
        private const int CTRL_R_TEXT_ALL = 6;

        /* Rich Text Id */
        private const int R_TEXT_PLAN = 0;
        private const int R_TEXT_DO = 1;
        private const int R_TEXT_CHECK = 2;
        private const int R_TEXT_ACT = 3;

        /* Radio Button Id */
        private const int R_BTN_PLAN = 0;
        private const int R_BTN_DO = 1;
        private const int R_BTN_CHECK = 2;
        private const int R_BTN_ACT = 3;

        /* Status Table */
        private readonly bool[,] STATUS_TABLE_CONTROL_ENABLE = new bool[,]{
           /* RadioButtons              | Buttons               | RichTextBox              */
           /* Plan   Do     Check  Act  | Inhert.   N.Stage     | All                      */
            { false, false, false, false, false,    false,        false}, /* Case未設定時  */
            { false, false, false, false, true ,    true ,        true }, /* Case Plan時   */
            { true , true , false, false, false,    true ,        true }, /* Case Do時     */
            { true , true , true , false, false,    true ,        true }, /* Case Check時  */
            { true , true , true , true , false,    true ,        true }, /* Case Act時    */
        };

        private readonly bool[,] STATUS_TABLE_R_TEXT_VISIBLE = new bool[,] {
            /* Plan     Do          Check       Act */
            { true,     false,      false,      false }, /* rbtnPlan    */
            { false,    true,       false,      false }, /* rbtnDo      */
            { false,    false,      true,       false }, /* rbtnCheck   */
            { false,    false,      false,      true  }, /* rbtnAct     */
        };


        /* Dialog Messages */


        #endregion // Constants
        #region Members
        private int _currentStatus;



        #endregion // Members
        #region Properties
        private int currentStatus {
            get { return _currentStatus; }
            set {
                _currentStatus = value % 7;
                SetEnable(_currentStatus);

                return;
            }
        }



        #endregion // Properties
        #endregion // Fields


        #region Methods

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public pdcaMainForm() {

            InitializeComponent();
            InitializeFields();

            return;
        }

        /// <summary>
        /// フィールドの初期化処理。
        /// </summary>
        private void InitializeFields() {

            currentStatus = STATUS_CASE_UNLOAD;

            /* debug */
            currentStatus = STATUS_PROGRESS_ACT;
            rtbPlan.Text = rtbPlan.Name.ToString();
            rtbDo.Text = rtbDo.Name.ToString();
            rtbCheck.Text = rtbCheck.Name.ToString();
            rtbAct.Text = rtbAct.Name.ToString();

            return;
        }

        /// <summary>
        /// コントロールのEnableプロパティを一括設定する。
        /// </summary>
        /// <param name="pStatus">Status</param>
        private void SetEnable(int pStatus) {

            rbtnPlan.Enabled        = STATUS_TABLE_CONTROL_ENABLE[ pStatus, CTRL_RADIO_PLAN];
            rbtnDo.Enabled          = STATUS_TABLE_CONTROL_ENABLE[ pStatus, CTRL_RADIO_DO];
            rbtnCheck.Enabled       = STATUS_TABLE_CONTROL_ENABLE[ pStatus, CTRL_RADIO_CHECK];
            rbtnAct.Enabled         = STATUS_TABLE_CONTROL_ENABLE[ pStatus, CTRL_RADIO_ACT];
            btnInheritance.Enabled  = STATUS_TABLE_CONTROL_ENABLE[ pStatus, CTRL_BUTTON_INHERIT];
            btnNextStage.Enabled    = STATUS_TABLE_CONTROL_ENABLE[ pStatus, CTRL_BUTTON_N_STAGE];
            rtbPlan.Enabled         = STATUS_TABLE_CONTROL_ENABLE[ pStatus, CTRL_R_TEXT_ALL];
            rtbDo.Enabled           = STATUS_TABLE_CONTROL_ENABLE[ pStatus, CTRL_R_TEXT_ALL];
            rtbCheck.Enabled        = STATUS_TABLE_CONTROL_ENABLE[ pStatus, CTRL_R_TEXT_ALL];
            rtbAct.Enabled          = STATUS_TABLE_CONTROL_ENABLE[ pStatus, CTRL_R_TEXT_ALL];

            return;
        }

        private void SetVisibleRichText( int pRbtnId) {

            rtbPlan.Visible = STATUS_TABLE_R_TEXT_VISIBLE[R_TEXT_PLAN , pRbtnId ];
            rtbDo.Visible = STATUS_TABLE_R_TEXT_VISIBLE[R_TEXT_DO, pRbtnId];
            rtbCheck.Visible = STATUS_TABLE_R_TEXT_VISIBLE[R_TEXT_CHECK, pRbtnId];
            rtbAct.Visible = STATUS_TABLE_R_TEXT_VISIBLE[R_TEXT_ACT, pRbtnId];

            return;
        } 

        #region EventHandler
        private void rbtnPlan_CheckedChanged(object sender, EventArgs e) {
            SetVisibleRichText(R_BTN_PLAN);
            return;
        }

        private void rbtnDo_CheckedChanged(object sender, EventArgs e) {
            SetVisibleRichText(R_BTN_DO);
            return;
        }

        private void rbtnCheck_CheckedChanged(object sender, EventArgs e) {
            SetVisibleRichText(R_BTN_CHECK);
            return;
        }

        private void rbtnAct_CheckedChanged(object sender, EventArgs e) {
            SetVisibleRichText(R_BTN_ACT);
            return;
        }
    }

    #endregion // EventHandler
#endregion // Methods
}
