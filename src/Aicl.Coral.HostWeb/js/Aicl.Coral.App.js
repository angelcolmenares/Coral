(function() {
	////////////////////////////////////////////////////////////////////////////////
	// Aicl.Coral.UserLogin.App
	var $App = function() {
		this.$1$ContenedorItemAreaField = null;
		this.$1$ContenedorWorkAreaField = null;
		this.$1$TituloModuloField = null;
		this.$1$WorkAreaField = null;
		this.$1$ItemAreaField = null;
		this.$modules = [];
	};
	$App.prototype = {
		get_$contenedorItemArea: function() {
			return this.$1$ContenedorItemAreaField;
		},
		set_$contenedorItemArea: function(value) {
			this.$1$ContenedorItemAreaField = value;
		},
		get_$contenedorWorkArea: function() {
			return this.$1$ContenedorWorkAreaField;
		},
		set_$contenedorWorkArea: function(value) {
			this.$1$ContenedorWorkAreaField = value;
		},
		get_$tituloModulo: function() {
			return this.$1$TituloModuloField;
		},
		set_$tituloModulo: function(value) {
			this.$1$TituloModuloField = value;
		},
		get_$workArea: function() {
			return this.$1$WorkAreaField;
		},
		set_$workArea: function(value) {
			this.$1$WorkAreaField = value;
		},
		get_$itemArea: function() {
			return this.$1$ItemAreaField;
		},
		set_$itemArea: function(value) {
			this.$1$ItemAreaField = value;
		},
		$showLoginForm: function() {
			var form = new $LoginForm(document.body);
			form.set_onLogin(ss.mkdel(this, this.$showUserMenu));
			form.show();
		},
		$showUserMenu: function(lr, lf) {
			lf.close();
			Cayita.UI.Div.createContainerFluid$1(null, ss.mkdel(this, function(fluid) {
				fluid.style.paddingLeft = '10px';
				fluid.style.paddingRight = '0px';
				Cayita.UI.Div.createRowFluid$1(fluid, ss.mkdel(this, function(row) {
					new Cayita.UI.Div.$ctor1(row, ss.mkdel(this, function(span) {
						span.className = 'span2';
						new Cayita.UI.SideNavBar(span, ss.mkdel(this, function(list) {
							for (var $t1 = 0; $t1 < lr.Menu.length; $t1++) {
								var menu = { $: lr.Menu[$t1] };
								Cayita.UI.Ext.addItem(list, ss.mkdel({ menu: menu, $this: this }, function(li, anchor) {
									$(anchor).text(this.menu.$.Titulo);
									$(anchor).on('click', ss.mkdel({ menu: this.menu, $this: this.$this }, function(e) {
										e.preventDefault();
										this.$this.get_$contenedorWorkArea().hide();
										this.$this.get_$contenedorItemArea().show();
										this.$this.get_$itemArea().empty();
										var div = document.createDocumentFragment();
										for (var $t2 = 0; $t2 < this.menu.$.Items.length; $t2++) {
											var item = { $: this.menu.$.Items[$t2] };
											(new Cayita.UI.Anchor.$ctor1(null, ss.mkdel({ item: item, $this: this.$this }, function(a) {
												a.className = 'c-icon';
												new Cayita.UI.Image(a, ss.mkdel({ item: this.item }, function(img) {
													img.src = this.item.$.Icono;
													img.className = 'img-rounded';
												}));
												$(a).on('click', ss.mkdel({ item: this.item, $this: this.$this }, function(ev) {
													ev.preventDefault();
													if (ss.contains(this.$this.$modules, this.item.$.Modulo)) {
														this.$this.$executeModule(this.item.$);
													}
													else {
														var rq = $.getScript('modulos/' + this.item.$.Modulo + '.js');
														rq.done(ss.mkdel({ item: this.item, $this: this.$this }, function(cb) {
															ss.add(this.$this.$modules, this.item.$.Modulo);
															this.$this.$executeModule(this.item.$);
														}));
														rq.fail(ss.mkdel({ item: this.item }, function(cb1) {
															console.log('fallo al cargar ' + this.item.$.Modulo + ' :' + rq.statusText + ' ', rq);
															Cayita.Javascript.UI.Bootbox.error('fallo al cargar ' + this.item.$.Modulo + ' :' + rq.statusText, 'Error');
														}));
													}
												}));
												new Cayita.UI.Span.$ctor1(a, ss.mkdel({ item: this.item }, function(sp) {
													sp.className = 'c-icon-label';
													sp.innerHTML = this.item.$.Titulo;
												}));
											}))).appendTo(div);
										}
										this.$this.get_$itemArea().element$1().appendChild(div);
									}));
								}));
							}
						}));
					}));
					this.set_$contenedorItemArea(new Cayita.UI.Div.$ctor1(row, ss.mkdel(this, function(div1) {
						div1.className = 'span10';
						div1.style.marginLeft = '10px';
						$(div1).append('<style>img {height: 60px;}  .c-icon {height: 160px;}</style>');
						this.set_$itemArea(new Cayita.UI.Div.$ctor1(div1, function(i) {
							i.className = 'c-icons';
							var m = document.createElement('h3');
							$(m).text('Bienvenido ' + lr.DisplayName);
							i.appendChild(m);
						}));
					})));
					this.set_$contenedorWorkArea(new Cayita.UI.Div.$ctor1(row, ss.mkdel(this, function(div2) {
						div2.className = 'span10';
						div2.style.marginLeft = '10px';
						$(div2).hide();
						new Cayita.UI.Div.$ctor1(div2, ss.mkdel(this, function(i1) {
							i1.className = 'c-panel';
							new Cayita.UI.Div.$ctor1(i1, ss.mkdel(this, function(h) {
								h.className = 'c-panel-header';
								new Cayita.UI.Icon.$ctor1(h, ss.mkdel(this, function(icon) {
									icon.className = 'icon-remove-circle';
									$(icon).on('click', ss.mkdel(this, function(evt) {
										evt.preventDefault();
										this.get_$contenedorWorkArea().hide();
										this.get_$contenedorItemArea().show();
									}));
								}));
								this.set_$tituloModulo(document.createElement('h3'));
								$(this.get_$tituloModulo()).text('Titulo del modulo');
								h.appendChild(this.get_$tituloModulo());
							}));
							this.set_$workArea(new Cayita.UI.Div.$ctor1(i1, function(ct) {
								ct.className = 'c-panel-content';
							}));
						}));
					})));
				}));
			})).appendTo$1(document.body);
		},
		$executeModule: function(item) {
			this.get_$workArea().empty();
			this.get_$contenedorItemArea().hide();
			this.get_$contenedorWorkArea().show();
			this.get_$tituloModulo().innerHTML = ss.replaceAllString(item.Titulo, '<br>', '');
			var $t1 = this.get_$workArea().element$1();
			window[ss.replaceAllString(item.Modulo, '.', '')]['execute']($t1);
		}
	};
	$App.main = function() {
		$(function() {
			var app = new $App();
			app.$showLoginForm();
		});
	};
	////////////////////////////////////////////////////////////////////////////////
	// Aicl.Coral.UserLogin.LoginForm
	var $LoginForm = function(parent) {
		this.$1$ParentField = null;
		this.$1$OnLoginField = null;
		this.$1$ContainerField = null;
		this.set_parent(parent);
	};
	$LoginForm.prototype = {
		get_parent: function() {
			return this.$1$ParentField;
		},
		set_parent: function(value) {
			this.$1$ParentField = value;
		},
		get_onLogin: function() {
			return this.$1$OnLoginField;
		},
		set_onLogin: function(value) {
			this.$1$OnLoginField = value;
		},
		get_$container: function() {
			return this.$1$ContainerField;
		},
		set_$container: function(value) {
			this.$1$ContainerField = value;
		},
		close: function() {
			this.get_$container().jQuery().remove();
		},
		show: function() {
			this.set_$container(Cayita.UI.Div.createContainer$1(null, ss.mkdel(this, function(container) {
				Cayita.UI.Div.createRow$1(container, ss.mkdel(this, function(row) {
					//
					new Cayita.UI.Div.$ctor1(row, ss.mkdel(this, function(element) {
						element.className = 'span4 offset4 well';
						new Cayita.UI.Legend.$ctor1(element, function(l) {
							$(l).text('Por favor inicie session');
						});
						new Cayita.UI.Form.$ctor1(element, ss.mkdel(this, function(fe) {
							fe.action = '/api/User/login';
							new Cayita.UI.TextField.$ctor1(fe, function(i) {
								$(i).attr('placeholder', 'NIT');
								i.name = 'Nit';
								i.className = 'span4';
								$(i).attr('required', true);
								$(i).attr('minlength', 8);
							});
							new Cayita.UI.TextField.$ctor1(fe, function(i1) {
								$(i1).attr('placeholder', 'nombre usuario');
								i1.name = 'Nombre';
								i1.className = 'span4';
								$(i1).attr('required', true);
								$(i1).attr('minlength', 4);
							});
							new Cayita.UI.TextField.$ctor1(fe, function(i2) {
								$(i2).attr('placeholder', 'clave');
								i2.name = 'Clave';
								i2.className = 'span4';
								$(i2).attr('required', true);
								$(i2).attr('minlength', 4);
								i2.type = 'password';
							});
							var bt = new Cayita.UI.SubmitButton.$ctor1(fe, function(b) {
								$(b).text('Iniciar Session');
								b.className = 'btn btn-info btn-block';
								$(b).button.defaults.loadingText = '  autenticando....';
							});
							var vo = ValidateOptions.setSubmitHandler(ValidateOptions.$ctor(), ss.mkdel(this, function(f) {
								bt.showLoadingText();
								var req = $.post(f.action, cayita.fn.serialize(f), function(cb) {
								}, 'json');
								req.done(ss.mkdel(this, function(d) {
									console.log(d);
									cayita.fn.clearForm(f);
									if (!ss.staticEquals(this.get_onLogin(), null)) {
										this.get_onLogin()(d, this);
									}
								}));
								req.fail(function(e) {
									console.log('fail :', req);
									Cayita.UI.Div.createAlertErrorBefore(fe.elements[0], req.status.toString() + ':' + (ss.startsWithString(req.statusText, 'ValidationException') ? 'Usario/clave no validos' : req.statusText));
								});
								req.always(function(a) {
									bt.resetLoadingText();
								});
							}));
							$(fe).validate(vo);
						}));
					}));
				}));
			})));
			this.get_parent().appendChild(this.get_$container().element$1());
		}
	};
	ss.registerClass(global, 'App', $App);
	ss.registerClass(global, 'LoginForm', $LoginForm);
})();
