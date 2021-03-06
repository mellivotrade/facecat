/*捂脸猫FaceCat框架 v1.0
 1.创始人-矿洞程序员-上海宁米科技创始人-脉脉KOL-陶德 (微信号:suade1984);
 2.联合创始人-上海宁米科技创始人-袁立涛(微信号:wx627378127);
 3.联合创始人-肖添龙(微信号:xiaotianlong_luu);
 4.联合开发者-陈晓阳(微信号:chenxiaoyangzxy)，助理-朱炜(微信号:cnnic_zhu);
 5.该框架开源协议为BSD，欢迎对我们的创业活动进行各种支持，欢迎更多开发者加入。
 包含C/C++,Java,C#,iOS,MacOS,Linux六个版本的图形和通讯服务框架。
 */

using System;
using System.Collections.Generic;

namespace FaceCat {
    /// <summary>
    /// 十字线标签
    /// </summary>
    public class CrossLineTip : FCProperty {
        /// <summary>
        /// 析构函数
        /// </summary>
        ~CrossLineTip() {
            delete();
        }

        protected bool m_allowUserPaint;

        /// <summary>
        /// 获取或设置是否允许用户绘图
        /// </summary>
        public virtual bool AllowUserPaint {
            get { return m_allowUserPaint; }
            set { m_allowUserPaint = value; }
        }

        protected long m_backColor = FCColor.argb(255, 0, 0);

        /// <summary>
        /// 获取或设置X轴提示框背景色
        /// </summary>
        public virtual long BackColor {
            get { return m_backColor; }
            set { m_backColor = value; }
        }

        private FCFont m_font = new FCFont();

        /// <summary>
        /// 获取或设置X轴提示框文字的字体
        /// </summary>
        public virtual FCFont Font {
            get { return m_font; }
            set { m_font = value; }
        }

        protected bool m_isDeleted;

        /// <summary>
        /// 获取或设置是否已被销毁
        /// </summary>
        public virtual bool IsDeleted {
            get { return m_isDeleted; }
        }

        protected long m_textColor = FCColor.argb(255, 255, 255);

        /// <summary>
        /// 获取或设置X轴提示框文字色
        /// </summary>
        public virtual long TextColor {
            get { return m_textColor; }
            set { m_textColor = value; }
        }

        protected bool m_visible = true;

        /// <summary>
        /// 获取或设置是否可见
        /// </summary>
        public virtual bool Visible {
            get { return m_visible; }
            set { m_visible = value; }
        }

        /// <summary>
        /// 销毁资源
        /// </summary>
        public void delete() {
            m_isDeleted = true;
        }

        /// <summary>
        /// 获取属性值
        /// </summary>
        /// <param name="name">属性名称</param>
        /// <param name="value">返回属性值</param>
        /// <param name="type">返回属性类型</param>
        public virtual void getProperty(String name, ref String value, ref String type) {
            if (name == "allowuserpaint") {
                type = "bool";
                value = FCStr.convertBoolToStr(AllowUserPaint);
            }
            else if (name == "backcolor") {
                type = "color";
                value = FCStr.convertColorToStr(BackColor);
            }
            else if (name == "font") {
                type = "font";
                value = FCStr.convertFontToStr(Font);
            }
            else if (name == "textcolor") {
                type = "color";
                value = FCStr.convertColorToStr(TextColor);
            }
            else if (name == "visible") {
                type = "bool";
                value = FCStr.convertBoolToStr(Visible);
            }
        }

        /// <summary>
        /// 获取属性名称列表
        /// </summary>
        /// <returns></returns>
        public virtual ArrayList<String> getPropertyNames() {
            ArrayList<String> propertyNames = new ArrayList<String>();
            propertyNames.AddRange(new String[] { "AllowUserPaint", "BackColor", "Font", "TextColor", "Visible" });
            return propertyNames;
        }

        /// <summary>
        /// 重绘方法
        /// </summary>
        /// <param name="paint">绘图对象</param>
        /// <param name="div">图层</param>
        /// <param name="rect">区域</param>
        public virtual void onPaint(FCPaint paint, ChartDiv div, FCRect rect) {

        }

        /// <summary>
        /// 设置属性
        /// </summary>
        /// <param name="name">属性名称</param>
        /// <param name="value">属性值</param>
        public virtual void setProperty(String name, String value) {
            if (name == "allowuserpaint") {
                AllowUserPaint = FCStr.convertStrToBool(value);
            }
            else if (name == "backcolor") {
                BackColor = FCStr.convertStrToColor(value);
            }
            else if (name == "font") {
                Font = FCStr.convertStrToFont(value);
            }
            else if (name == "textcolor") {
                TextColor = FCStr.convertStrToColor(value);
            }
            else if (name == "visible") {
                Visible = FCStr.convertStrToBool(value);
            }
        }
    }
}
