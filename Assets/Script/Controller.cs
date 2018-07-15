using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour {

	public Text[] texts;
	public Text startText;
	public Text endText;
	public Text routeText;

	private int s_v;
	private int e_v;
	private const int MaxVertexNum = 25;
	private const int INF = 32767;

	public void ButtonClicked0() {
		if (startText.text == "") {
			startText.text = "乌鲁木齐";
		} else {
			if (endText.text == "") {
				endText.text = "乌鲁木齐";
			}
		}
	}

	public void ButtonClicked1() {
		if (startText.text == "") {
			startText.text = "西宁";
		} else {
			if (endText.text == "") {
				endText.text = "西宁";
			}
		}
	}

	public void ButtonClicked2() {
		if (startText.text == "") {
			startText.text = "昆明";
		} else {
			if (endText.text == "") {
				endText.text = "昆明";
			}
		}
	}

	public void ButtonClicked3() {
		if (startText.text == "") {
			startText.text = "兰州";
		} else {
			if (endText.text == "") {
				endText.text = "兰州";
			}
		}
	}

	public void ButtonClicked4() {
		if (startText.text == "") {
			startText.text = "成都";
		} else {
			if (endText.text == "") {
				endText.text = "成都";
			}
		}
	}

	public void ButtonClicked5() {
		if (startText.text == "") {
			startText.text = "贵阳";
		} else {
			if (endText.text == "") {
				endText.text = "贵阳";
			}
		}
	}

	public void ButtonClicked6() {
		if (startText.text == "") {
			startText.text = "南宁";
		} else {
			if (endText.text == "") {
				endText.text = "南宁";
			}
		}
	}

	public void ButtonClicked7() {
		if (startText.text == "") {
			startText.text = "西安";
		} else {
			if (endText.text == "") {
				endText.text = "西安";
			}
		}
	}

	public void ButtonClicked8() {
		if (startText.text == "") {
			startText.text = "柳州";
		} else {
			if (endText.text == "") {
				endText.text = "柳州";
			}
		}
	}

	public void ButtonClicked9() {
		if (startText.text == "") {
			startText.text = "呼和浩特";
		} else {
			if (endText.text == "") {
				endText.text = "呼和浩特";
			}
		}
	}

	public void ButtonClicked10() {
		if (startText.text == "") {
			startText.text = "北京";
		} else {
			if (endText.text == "") {
				endText.text = "北京";
			}
		}
	}

	public void ButtonClicked11() {
		if (startText.text == "") {
			startText.text = "郑州";
		} else {
			if (endText.text == "") {
				endText.text = "郑州";
			}
		}
	}

	public void ButtonClicked12() {
		if (startText.text == "") {
			startText.text = "武汉";
		} else {
			if (endText.text == "") {
				endText.text = "武汉";
			}
		}
	}

	public void ButtonClicked13() {
		if (startText.text == "") {
			startText.text = "株州";
		} else {
			if (endText.text == "") {
				endText.text = "株州";
			}
		}
	}

	public void ButtonClicked14() {
		if (startText.text == "") {
			startText.text = "广州";
		} else {
			if (endText.text == "") {
				endText.text = "广州";
			}
		}
	}

	public void ButtonClicked15() {
		if (startText.text == "") {
			startText.text = "深圳";
		} else {
			if (endText.text == "") {
				endText.text = "深圳";
			}
		}
	}

	public void ButtonClicked16() {
		if (startText.text == "") {
			startText.text = "天津";
		} else {
			if (endText.text == "") {
				endText.text = "天津";
			}
		}
	}

	public void ButtonClicked17() {
		if (startText.text == "") {
			startText.text = "徐州";
		} else {
			if (endText.text == "") {
				endText.text = "徐州";
			}
		}
	}

	public void ButtonClicked18() {
		if (startText.text == "") {
			startText.text = "南昌";
		} else {
			if (endText.text == "") {
				endText.text = "南昌";
			}
		}
	}

	public void ButtonClicked19() {
		if (startText.text == "") {
			startText.text = "上海";
		} else {
			if (endText.text == "") {
				endText.text = "上海";
			}
		}
	}

	public void ButtonClicked20() {
		if (startText.text == "") {
			startText.text = "福州";
		} else {
			if (endText.text == "") {
				endText.text = "福州";
			}
		}
	}

	public void ButtonClicked21() {
		if (startText.text == "") {
			startText.text = "大连";
		} else {
			if (endText.text == "") {
				endText.text = "大连";
			}
		}
	}

	public void ButtonClicked22() {
		if (startText.text == "") {
			startText.text = "沈阳";
		} else {
			if (endText.text == "") {
				endText.text = "沈阳";
			}
		}
	}

	public void ButtonClicked23() {
		if (startText.text == "") {
			startText.text = "长春";
		} else {
			if (endText.text == "") {
				endText.text = "长春";
			}
		}
	}

	public void ButtonClicked24() {
		if (startText.text == "") {
			startText.text = "哈尔滨";
		} else {
			if (endText.text == "") {
				endText.text = "哈尔滨";
			}
		}
	}

	public void clearButtonClicked() {
		SceneManager.LoadScene ("UI");
	}

	struct MGraph {
		public int[,] edges;
		public int n,e;
	}

	public void findButtonClicked() {
		if (startText.text != "" && endText.text != "") {
			int[,] A = new int[MaxVertexNum, MaxVertexNum];
			int[,] path = new int[MaxVertexNum, MaxVertexNum];
			
			s_v = find_v (startText.text);
			e_v = find_v (endText.text);
			MGraph myGraph = creatGraph ();
			Floyd (myGraph, A, path);
			routeText.text = "最短路径长度为:" + A [s_v, e_v];
			changeColor (s_v);
			Ppath (myGraph, path, s_v, e_v);	
			changeColor (e_v);
		}
	}

	private MGraph creatGraph() {
		MGraph myGraph;
		myGraph.n = MaxVertexNum;
		myGraph.e = 30;
		myGraph.edges = new int[MaxVertexNum, MaxVertexNum]; 
		for (int i = 0; i < MaxVertexNum; i++) {
			for (int j = 0; j < MaxVertexNum; j++) {
				myGraph.edges [i,j] = INF;
				if (i == j)
					myGraph.edges [i, j] = 0;
			}
		}
		myGraph.edges [3, 0] = myGraph.edges [0, 3] = 1892;
		myGraph.edges [3, 1] = myGraph.edges [1, 3] = 216;
		myGraph.edges [4, 2] = myGraph.edges [2, 4] = 1100;
		myGraph.edges [5, 2] = myGraph.edges [2, 5] = 639;
		myGraph.edges [9, 3] = myGraph.edges [3, 9] = 1145;
		myGraph.edges [7, 3] = myGraph.edges [3, 7] = 676;
		myGraph.edges [7, 4] = myGraph.edges [4, 7] = 842;
		myGraph.edges [5, 4] = myGraph.edges [4, 5] = 967;
		myGraph.edges [8, 5] = myGraph.edges [5, 8] = 607;
		myGraph.edges [8, 6] = myGraph.edges [6, 8] = 255;
		myGraph.edges [10, 9] = myGraph.edges [9, 10] = 668;
		myGraph.edges [11, 7] = myGraph.edges [7, 11] = 511;
		myGraph.edges [13, 5] = myGraph.edges [5, 13] = 902;
		myGraph.edges [13, 8] = myGraph.edges [8, 13] = 672;
		myGraph.edges [11, 10] = myGraph.edges [10, 11] = 695;
		myGraph.edges [12, 11] = myGraph.edges [11, 12] = 534;
		myGraph.edges [13, 12] = myGraph.edges [12, 13] = 409;
		myGraph.edges [14, 13] = myGraph.edges [13, 14] = 675;
		myGraph.edges [15, 14] = myGraph.edges [14, 15] = 140;
		myGraph.edges [16, 10] = myGraph.edges [10, 16] = 137;
		myGraph.edges [17, 11] = myGraph.edges [11, 17] = 349;
		myGraph.edges [18, 13] = myGraph.edges [13, 18] = 367;
		myGraph.edges [17, 16] = myGraph.edges [16, 17] = 674;
		myGraph.edges [19, 17] = myGraph.edges [17, 19] = 651;
		myGraph.edges [19, 18] = myGraph.edges [18, 19] = 825;
		myGraph.edges [20, 18] = myGraph.edges [18, 20] = 622;
		myGraph.edges [22, 16] = myGraph.edges [16, 22] = 704;
		myGraph.edges [22, 21] = myGraph.edges [21, 22] = 397;
		myGraph.edges [23, 22] = myGraph.edges [22, 23] = 305;
		myGraph.edges [24, 23] = myGraph.edges [23, 24] = 242;
		return myGraph;
	}

	private void Floyd(MGraph G, int[,] A, int[,] path) {

		for (int i = 0; i < G.n; i++)
			for (int j = 0; j < G.n; j++) {
				A [i, j] = G.edges [i, j];
				path [i, j] = -1;
			}

		for (int k = 0; k < G.n; k++)
			for (int i = 0; i < G.n; i++)
				for (int j = 0; j < G.n; j++)
					if (A [i, j] > A [i, k] + A [k, j]) {
						A [i, j] = A [i, k] + A [k, j];
						path [i, j] = k;
					}
	}

	private void Ppath(MGraph G, int[,] path, int i, int j) {
		int k;
		k = path[i, j];
		if (k == -1)
			return;
		Ppath (G, path, i, k);
		changeColor (k);
		Ppath (G, path, k, j);
	}

	private void changeColor (int i) {
		texts [i].color = Color.green;
	}

	private int find_v(string text) {
		switch (text) {
		case "乌鲁木齐": return 0;
		case "西宁": return 1;
		case "昆明": return 2;
		case "兰州": return 3;
		case "成都": return 4;
		case "贵阳": return 5;
		case "南宁": return 6;
		case "西安": return 7;
		case "柳州": return 8;
		case "呼和浩特": return 9;
		case "北京": return 10;
		case "郑州": return 11;
		case "武汉": return 12;
		case "株州": return 13;
		case "广州": return 14;
		case "深圳": return 15;
		case "天津": return 16;
		case "徐州": return 17;
		case "南昌": return 18;
		case "上海": return 19;
		case "福州": return 20;
		case "大连": return 21;
		case "沈阳": return 22;
		case "长春": return 23;
		case "哈尔滨": return 24;
		default: return 25;
		}
	}
}
