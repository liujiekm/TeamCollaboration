<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="TeamCollaboration.Web.Demo.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script src="http://localhost/TeamCollaboration.Web/Scripts/jquery-1.10.2.js"></script>
    <link href="http://localhost/TeamCollaboration.Web/Content/bootstrap.css" rel="stylesheet" />
    <link href="http://localhost/TeamCollaboration.Web/Content/TeamCollaboration.css" rel="stylesheet" />
    <link href="http://localhost/TeamCollaboration.Web/Content/bootstrap-datetimepicker.css" rel="stylesheet" />
    <script src="http://localhost/TeamCollaboration.Web/Scripts/bootstrap.js"></script>
    <script src="http://localhost/TeamCollaboration.Web/Scripts/bootstrap-datetimepicker.js"></script>
    <script src="http://localhost/TeamCollaboration.Web/Scripts/bootstrap-datetimepicker.zh-CN.js"></script>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script type="text/javascript">      
        $(function () {
            $('#TaskTab a:first').tab('show');//初始化显示哪个tab 
            $('#TaskTab a').click(function (e) {
                e.preventDefault();//阻止a链接的跳转行为 
                $(this).tab('show');//显示当前选中的链接及关联的content
            })
        })
        $('#TaskTab a[href="#profile"]').tab('show'); // Select tab by name 
        $('#TaskTab a:first').tab('show'); // Select first tab 
        $('#TaskTab a:last').tab('show'); // Select last tab 
        $('#TaskTab li:eq(2) a').tab('show');

        $(function () {
            $('.time1').datetimepicker({
                language: 'zh-CN',
                format: 'yyyy-mm-dd hh:ii',
                weekStart: 1,
                todayBtn: 1,
                autoclose: 1,
                todayHighlight: 1,
                startView: 2,
                minView: 0,
                maxView: 1,
                forceParse: 0
            });
            $('.time2').datetimepicker({
                language: 'zh-CN',
                format: 'yyyy-mm-dd hh:ii',
                weekStart: 1,
                todayBtn: 1,
                autoclose: 1,
                todayHighlight: 1,
                startView: 2,
                minView: 0,
                maxView: 1,
                forceParse: 0
            });
        });
    </script>
</head>
<body>
    <%--taskDetail--%>
    <div class="container-fluid">
        <%--content--%>
        <div class ="col-xs-11 col-md-11 Tasking" id="Task">
            <div class="row tab-content">
                <ul class="nav nav-tabs TaskMenu" id="TaskTab"> 
                    <li class="active">
                        <a href="#TaskReminder" class="a-text">
                            <span class="glyphicon glyphicon-volume-up TaskAlertIcon"></span>
                            <div class="TaskReminder">任务提醒</div>
                        </a>
                    </li> 
                    <li>
                        <a class="a-text" href="#TaskList">
                            <span class="glyphicon glyphicon-list TaskListIcon"></span>
                            <div class="TaskListContent">任务列表</div>
                        </a>
                    </li> 
                </ul>



                <div class="tab-content tab-contentList">
                     <%--TaskReminder --%>
                    <div class="tab-pane active" id="TaskReminder">
                        <div class="board">
                            <div class="row board-title">任务提醒</div>
                            <div class="row">
                                <p class="board-contents">任务内容</p>
                            </div>
                        </div>
                    </div>


                    <%-- TaskList --%>
                    <div class="tab-pane" id="TaskList">
                        <div class="row marginBorder">

                          <%--   Time Picker--%> 
                            <div class="col-xs-2 col-md-2 TaskFunctionMenu">
                                <div class="TaskFunctionMainMenu">任务紧急程度</div>

                                <div class="greenblock"></div>
                                <div class="blocktext">轻松</div> 
                                <div class="orangeblock"></div>
                                <div class="blocktext">中等</div>  
                                <div class="redblock"></div>
                                <div class="blocktext">重要</div>                             


                                <div class="TaskFunctionMainMenu">任务状态</div>

                                <div class="blueblock"></div>
                                <div class="blocktext">未开始</div> 
                                <div class="yellowblock"></div>
                                <div class="blocktext">进行中</div>  
                                <div class="greenblock1"></div>
                                <div class="blocktext">已完成</div> 
                                <div class="grayblock"></div>
                                <div class="blocktext">已过期</div> 

                                <div class="btn newTask" data-toggle="modal" data-target="#addtaskModal">新建任务</div>
                                <!-- line modal -->
                                <div class="modal fade" id="addtaskModal" tabindex="-1" role="dialog" aria-labelledby="modalLabel" aria-hidden="true">
                                  <div class="modal-dialog">
	                                <div class="modal-content">
		                                <div class="modal-header">
			                                <button type="button" class="close" data-dismiss="modal"><span aria-hidden="true">×</span><span class="sr-only">Close</span></button>
			                                <h3 class="modal-title" id="lineModalLabel">新建任务</h3>
		                                </div>
		                                <div class="modal-body">
			
                                            <!-- content goes here -->
			                                <form>
                                              <div class="form-group">
                                                <label>任务紧急程度</label>
                                                    <select class="form-control formText">
                                                        <option value="0">轻松</option>
                                                        <option value="1">中等</option>
                                                        <option value="2">重要</option>
                                                    </select>
                                              </div>
                                              <div class="form-group">
                                                <label>任务名称</label>
                                                <input class="form-control taskName"/>
                                              </div>
                                              <div class="form-group">
                                                <label>任务描述</label>
                                                <textarea class="taskDescription"></textarea>
                                              </div>
                                              <div class="form-group">
                                                <label>任务时间</label>
                                                <input size="16" type="text" value="" class="time1"/>
                                                <label>—</label>
                                                <input size="16" type="text" value="" class="time2"/>  
                                                <input class="timeSelect"/>    
                                                <label>工时</label>               
                                              </div>
                                              <div class="form-group">
                                                <label>任务人</label>
                                                <input class="selectTaskpeople"/>
                                              </div>
                                              <div class="form-group">
                                                <label>任务到期前提醒</label>
                                                <label class="aheadoftime" >时间，提前</label>
                                                  <select class="form-control aheadoftimes">
                                                      <option value="0">30分钟</option>
                                                      <option value="1">1小时</option>
                                                      <option value="2">5小时</option>
                                                      <option value="3">12小时</option>
                                                      <option value="4">24小时</option>
                                                      <option value="4">48小时</option>
                                                  </select>
                                                <div class="checkbox">
                                                    <label>
                                                        <input type="checkbox" />邮箱提醒
                                                    </label>
                                                </div>
                                              </div>                                             
                                            </form>
		                                </div>
		                                <div class="modal-footer">
			                                <div class="btn-group btn-group-justified" role="group" aria-label="group button">
				                                
			                                </div>
		                                </div>
	                                </div>
                                  </div>
                                </div>





                                <div class="btn newTask">修改任务</div>
                                <div class="btn newTask">删除任务</div>

                                <%-- 时间控件 --%>
                                <div></div>

                            </div>

                            <%-- Task details   --%>
                            <div class="col-xs-10 col-md-10">
                                <div class="row TaskTimes">
                                    <div class="btn LeftArrow"></div>
                                    <div class="btn">2015年XX月XX日</div>
                                    <div class="btn RightArrow"></div>
                                </div>
                                <div class="row TadkDetails">
                                    <div class="col-xs-3 col-md-3 col-empty">
                                        <div class="row blueblock1"></div>
                                    </div>
                                    <div class="col-xs-3 col-md-3 col-empty">
                                        <div class="yellowblock1"></div>
                                    </div>
                                    <div class="col-xs-3 col-md-3 col-empty">
                                        <div class="greenblock2"></div>
                                    </div>
                                    <div class="col-xs-3 col-md-3 col-empty">
                                        <div class="grayblock1"></div>
                                    </div>
                                </div>
                            </div>  
                                                     
                        </div>
                    </div>


                </div> 
            </div>
        </div>
    </div>
</body>
</html>
