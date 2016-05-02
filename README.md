# SkillTreeMVCHomeWork

## Day 1
- 請使用「MoneyTemplate.html」作為樣版（就是你家設計提供的版型）
- 必須使用 Layout
- 下方列表必須有假資料（禁止寫死在HTML）可使用 ViewModel
- 上方表單部分如果有時間可以依據需求調整，如果沒時間可以將「MoneyTemplate.html」的部分直接複製過來。


## Day 2
- 請將記帳本呈現資料的部分改為真 DB !
- 可使用 EF , ADO.NET
- 範例資料庫請使用 HomeWorkDB 內的資料
- 額外挑戰
	- UnitOfWork
	- Repository

## Day 3
### 初階版
- 必須真的寫進資料庫
- 所有欄位必填
	- 「金額」只能輸入正整數
	- 「日期」不得大於今天
	- 「備註」最多輸入100個字元（備註為 TextArea）
- 列表加入顏色變換
	- 類型的「支出」字樣顯現為紅色
	- 類型的「收入」字樣顯現為藍色

### 進階版
- 將記帳本的寫入功能改為 AJAX
- 你將會遇到以下問題
- 如何片段更新下方 List

## Day 4
- 要登入才能新增資料（若為ajax, 請維持ajax)
- 管理員 Area
	- 可以編輯所有歷史資料
	- 非管理員進入會跳回首頁
