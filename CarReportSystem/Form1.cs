﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CarReportSystem.CarReport;

namespace CarReportSystem
{
    public partial class Form1 : Form
    {
        //記事データを入れるバインディングリスト
        BindingList<CarReport> _Cars = new BindingList<CarReport>();

        public Form1()
        {
            InitializeComponent();
            //dgvNewsData.DataSource = _Cars;

        }

        //登録ボタン
        private void btAdd_Click(object sender, EventArgs e)
        {
            if (cbAuthor.Text == "")
            {
                MessageBox.Show("記録者を入力してください");
                return;
            }

            //CarReportオブジェクトの作成
            CarReport obj = new CarReport
            {
                CreatedDate = dtpDate.Value,
                Author = cbAuthor.Text,
                Maker = MakerSerect(),
                Name = cbCar.Text,
                Report = textBox.Text,
                Picture = pbImage.Image,
            };

            //メーカーをコンボボックスの入力候補に登録
            setComboBoxCar(cbCar.Text);
            setComboBoxAuthor(cbAuthor.Text);

            //BindingListへ登録
            //_Cars.Add(obj);
            _Cars.Insert(0, obj); //リストの先頭（インデックス０）へ追加

            //高さを自動調整
            //Form1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            //次の入力に備えて各項目をクリア
            inputItemAllClear();
            initButtons();

            //Form1.ClearSelection();    //選択行をクリア
        }

        private CarMaker MakerSerect()
        {
            if (rbToyota.Checked == true)
            {
                return CarMaker.トヨタ;
            }
            else if (rbNissan.Checked == true)
            {
                return CarMaker.日産;
            }
            else if (rbHonda.Checked == true)
            {
                return CarMaker.ホンダ;
            }
            else if (rbSubaru.Checked == true)
            {
                return CarMaker.スバル;
            }
            else if (rbGaisya.Checked == true)
            {
                return CarMaker.外車;
            }
            else if (rbSonota.Checked == true)
            {
                return CarMaker.その他;
            }

            return CarMaker.DEFAULT;
        }

        //入力項目をクリア
        private void inputItemAllClear()
        {
            cbAuthor.Text = "";
            cbCar.Text = "";
            textBox.Text = "";
            pbImage.Image = null;
        }

        //記録者コンボボックスの入力候補登録
        private void setComboBoxAuthor(string author)
        {
            if (!cbAuthor.Items.Contains(author))
            {
                //コンボボックスの候補に追加
                cbAuthor.Items.Add(author);
            }
        }
        //車名コンボボックスの入力候補登録
        private void setComboBoxCar(string car)
        {
            if (!cbCar.Items.Contains(car))
            {
                //コンボボックスの候補に追加
                cbCar.Items.Add(car);
            }
        }

        //画像を開く
        private void btOpenImage_Click(object sender, EventArgs e)
        {
            if (ofdOpenImage.ShowDialog() == DialogResult.OK)
            {
                //選択した画像をピクチャーボックスに表示
                pbImage.Image = Image.FromFile(ofdOpenImage.FileName);
                //ピクチャーボックスのサイズに画像を調整
                pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        //画像の削除ボタン
        private void btClearImage_Click(object sender, EventArgs e)
        {
            pbImage.Image = null;
        }

        /*
        private void dgvNewsData_Click(object sender, EventArgs e)
        {
            var test = dgvNewsData.CurrentRow.Cells[2].Value;   //選択している行の指定したセルの値を取得

            if (Form1.CurrentRow == null)
                return;

            //選択したレコードを取り出す
            //データグリッドビューで選択した行のインデックスを元に
            //BindingListのデータを取得する
            CarReport selectedCar = _Cars[Form1.CurrentRow.Index];
            dtpDate.Value = selectedCar.CreatedDate;
            cbAuthor.Text = selectedCar.Author;
            cbCar.Text = selectedCar.Name;
            tb.Text = selectedCar.Report;
            pbImage.Image = selectedCar.Picture;
            
        }*/

        //マスク処理
        private void initButtons()
        {
            if (_Cars.Count > 0)
            {         
                btSetuzoku.Enabled = true;
            }
            else
            {
                btSetuzoku.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        /*削除ボタン
        private void btDelete_Click(object sender, EventArgs e)
        {
            //_Cars.RemoveAt(Form1.CurrentRow.Index);
            //initButtons();
            //inputItemAllClear();
            //Form1.ClearSelection();
        }

        private void carReportBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.carReportBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202005DataSet);

        }*/

        //ファイルメニュー
        private void 新規入力ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            inputItemAllClear();
        }

        private void 終了XToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 開くToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'infosys202005DataSet.CarReport' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.carReportTableAdapter.Fill(this.infosys202005DataSet.CarReport);
            //dgvNewsData.Columns[0].Visible = false; //idを非表示にする
        }

        private void 接続ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.carReportTableAdapter.Fill(this.infosys202005DataSet.CarReport);
        }

        //終了ボタン
        private void btEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //接続ボタン
        private void btSetuzoku_Click(object sender, EventArgs e)
        {
            this.carReportTableAdapter.Fill(this.infosys202005DataSet.CarReport);
            initButtons();
        }

        //保存ボタン
        private void btSave_Click(object sender, EventArgs e)
        {
            //セーブファイルダイアログを表示
            if (sfdSaveData.ShowDialog() == DialogResult.OK)
            {
                BinaryFormatter formatter = new BinaryFormatter();

                //ファイルストリームを生成
                using (FileStream fs = new FileStream(sfdSaveData.FileName, FileMode.Create))
                {
                    try
                    {
                        //シリアル化して保存
                        formatter.Serialize(fs, _Cars);
                    }
                    catch (SerializationException se)
                    {
                        Console.WriteLine("Failed to serialize. Reason: " + se.Message);
                        throw;
                    }
                }
            }
        }

        //データグリッドビューのデータを読み込む
        private void dgvNewsData_Click(object sender, EventArgs e)
        {
            try
            {   //選択したレコード（行）の、インデックスで指定した項目を取り出す

                //作成日
                dtpDate.Value = (DateTime)dgvNewsData.CurrentRow.Cells[1].Value;
                //編集者
                cbAuthor.Text = dgvNewsData.CurrentRow.Cells[2].Value.ToString();
                //メーカー
                var maker = dgvNewsData.CurrentRow.Cells[3].Value;
                //車名
                cbCar.Text = dgvNewsData.CurrentRow.Cells[4].Value.ToString();
                //レポート
                textBox.Text = dgvNewsData.CurrentRow.Cells[5].Value.ToString();
                //画像
                pbImage.Image = ByteArrayToImage((byte[])dgvNewsData.CurrentRow.Cells[6].Value);

                //ラジオボタンの設定
                setRadioButtunMaker((string)maker);

            }
            //以下エラー
            catch (InvalidCastException) //画像がDBに登録されていないとき
            {
                pbImage.Image = null;
            }
            catch(Exception ex) //上記以外のデータ全て拾う
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void setRadioButtunMaker(string carMaker)
        {
            switch (carMaker)
            {
                case "トヨタ":
                    rbToyota.Checked = true;
                    break;

                case "日産":
                    rbNissan.Checked = true;
                    break;

                case "ホンダ":
                    rbHonda.Checked = true;
                    break;

                case "スバル":
                    rbSubaru.Checked = true;
                    break;

                case "外車":
                    rbGaisya.Checked = true;
                    break;

                case "その他":
                    rbSonota.Checked = true;
                    break;
            }
        }

        //データベースから画像をピクチャーボックスへ表示するとき
        // バイト配列をImageオブジェクトに変換
        public static Image ByteArrayToImage(byte[] byteData)
        {
            ImageConverter imgconv = new ImageConverter();
            Image img = (Image)imgconv.ConvertFrom(byteData);
            return img;
        }

        //ピクチャーボックスからデータベースへ登録するとき
        // Imageオブジェクトをバイト配列に変換
        public static byte[] ImageToByteArray(Image img)
        {
            ImageConverter imgconv = new ImageConverter();
            byte[] byteData = (byte[])imgconv.ConvertTo(img, typeof(byte[]));
            return byteData;
        }

        //修正ボタン
        private void btRevice_Click(object sender, EventArgs e)
        {
            dgvNewsData.CurrentRow.Cells[1].Value = dtpDate;
            dgvNewsData.CurrentRow.Cells[2].Value = cbAuthor.Text;
            dgvNewsData.CurrentRow.Cells[3].Value = getMakerRadioButton();
            dgvNewsData.CurrentRow.Cells[4].Value = cbCar.Text;
            dgvNewsData.CurrentRow.Cells[5].Value = textBox.Text;

            if (pbImage.Image != null)
            {
                dgvNewsData.CurrentRow.Cells[6].Value = ImageToByteArray(pbImage.Image);
            }
            else
            {
                dgvNewsData.CurrentRow.Cells[6].Value = null;
            }

            //データベース更新（反映）
            this.Validate();
            this.carReportBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202005DataSet);

        }
        private string getMakerRadioButton()
        {
            if (rbToyota.Checked)
            {
                return rbToyota.Text;
            }
            else if (rbNissan.Checked)
            {
                return rbNissan.Text;
            }
            else if (rbHonda.Checked)
            {
                return rbHonda.Text;
            }
            else if (rbSubaru.Checked)
            {
                return rbSubaru.Text;
            }
            else if (rbGaisya.Checked)
            {
                return rbGaisya.Text;
            }
            else if (rbSonota.Checked)
            {
                return rbSonota.Text;
            }
            else
            {
                return null;
            }
        }

        //削除ボタン
        private void btDelete_Click(object sender, EventArgs e)
        {
            initButtons();
            inputItemAllClear();
        }

        //実行ボタン
        private void btSearchExe_Click(object sender, EventArgs e)
        {

            //車名
            this.carReportTableAdapter.FillByCarName(this.infosys202005DataSet.CarReport,tbSearchCarName.Text,tbSearchMaker.Text);
            //メーカー
            this.carReportTableAdapter.FillByCarName(this.infosys202005DataSet.CarReport,tbSearchCarName.Text,tbSearchMaker.Text);
            //日付
            this.carReportTableAdapter.FillByCreatedDate(this.infosys202005DataSet.CarReport, dtpSearchDate.Text, tbSearchCarName.Text, tbSearchMaker.Text);

        }
    }
}
